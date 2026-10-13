using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AromaBlissPOS
{
    public partial class FrmProducts : Form
    {
        // 0 = new product, >0 = update existing product
        int selectedId = 0;

        public FrmProducts()
        {
            InitializeComponent();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            // Apply shared theme
            DatabaseHelper.ApplyTheme(this);

            // Force the top header label back to White
            lblTitle.ForeColor = Color.White;

            LoadCategories();
            LoadData();

            // Add ImagePath column if it doesn't already exist
            try
            {
                DatabaseHelper.ExecuteNonQuery("ALTER TABLE Products ADD COLUMN ImagePath TEXT;");
            }
            catch
            {
                // Ignore error if the column already exists
            }
        }

        // Load categories into combobox
        void LoadCategories()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT CategoryID, CategoryName FROM Categories;");
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
        }

        // Load all products into table
        void LoadData()
        {
            dgvProducts.DataSource = DatabaseHelper.ExecuteQuery(
        "SELECT p.ProductID AS [ID], p.ProductName AS [Product], c.CategoryName AS [Category], p.UnitPrice AS [Price (LKR)], p.StockQuantity AS [Stock], p.CategoryID, p.ImagePath " +
        "FROM Products p " +
        "LEFT JOIN Categories c ON p.CategoryID = c.CategoryID " +
        "ORDER BY p.ProductID DESC;");

            // hide raw foreign key column from user
            if (dgvProducts.Columns["CategoryID"] != null)
            {
                dgvProducts.Columns["CategoryID"].Visible = false;
            }

            // hide image path column from grid table
            if (dgvProducts.Columns["ImagePath"] != null)
            {
                dgvProducts.Columns["ImagePath"].Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cleanPrice = txtPrice.Text.Trim().Replace(",", "");
            string cleanStock = txtStock.Text.Trim().Replace(",", "");

            // validation check
            if (txtProdName.Text == "" || cleanPrice == "" || cleanStock == "" || cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            // insert new product with ImagePath
            if (selectedId == 0)
            {
                DatabaseHelper.ExecuteNonQuery("INSERT INTO Products (ProductName, CategoryID, UnitPrice, StockQuantity, ImagePath) " +
                    "VALUES ('" + txtProdName.Text + "', " + cmbCategory.SelectedValue + ", " + cleanPrice + ", " + cleanStock + ", '" + selectedImagePath + "');");
            }
            // update selected product with ImagePath
            else
            {
                DatabaseHelper.ExecuteNonQuery("UPDATE Products SET ProductName='" + txtProdName.Text + "', CategoryID=" + cmbCategory.SelectedValue + ", UnitPrice=" + cleanPrice + ", StockQuantity=" + cleanStock + ", ImagePath='" + selectedImagePath + "' WHERE ProductID=" + selectedId + ";");
            }

            ClearFields();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DatabaseHelper.ExecuteNonQuery("DELETE FROM Products WHERE ProductID=" + selectedId + ";");
                ClearFields();
                LoadData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var r = dgvProducts.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(r.Cells["ID"].Value);
            txtProdName.Text = r.Cells["Product"].Value.ToString();
            cmbCategory.SelectedValue = r.Cells["CategoryID"].Value;
            txtPrice.Text = r.Cells["Price (LKR)"].Value.ToString();
            txtStock.Text = r.Cells["Stock"].Value.ToString();
            btnSave.Text = "Update";

            // Safely clear old image
            if (picProduct.Image != null)
            {
                picProduct.Image.Dispose();
                picProduct.Image = null;
            }

            string imgPath = r.Cells["ImagePath"]?.Value?.ToString();
            if (!string.IsNullOrEmpty(imgPath))
            {
                string fullPath = System.IO.Path.Combine(Application.StartupPath, imgPath);
                if (System.IO.File.Exists(fullPath))
                {
                    selectedImagePath = imgPath;
                    using (var stream = new System.IO.FileStream(fullPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        picProduct.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    selectedImagePath = "";
                }
            }
            else
            {
                selectedImagePath = "";
            }
        }

        // Clear textboxes and reset state
        void ClearFields()
        {
            selectedId = 0;
            txtProdName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            btnSave.Text = "Save";
            txtProdName.Focus();

            // Reset product image preview and path variable
            selectedImagePath = "";
            picProduct.Image = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = DatabaseHelper.ExecuteQuery(
          "SELECT p.ProductID AS [ID], p.ProductName AS [Product], c.CategoryName AS [Category], p.UnitPrice AS [Price (LKR)], p.StockQuantity AS [Stock], p.CategoryID, p.ImagePath " +
          "FROM Products p " +
          "LEFT JOIN Categories c ON p.CategoryID = c.CategoryID " +
          "WHERE p.ProductName LIKE '%" + txtSearch.Text.Trim().Replace("'", "''") + "%' " +
          "ORDER BY p.ProductID DESC;");

            if (dgvProducts.Columns["CategoryID"] != null)
            {
                dgvProducts.Columns["CategoryID"].Visible = false;
            }

            if (dgvProducts.Columns["ImagePath"] != null)
            {
                dgvProducts.Columns["ImagePath"].Visible = false;
            }
        }

        // Store selected image path
        private string selectedImagePath = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string imagesFolder = System.IO.Path.Combine(Application.StartupPath, "Images");
                    if (!System.IO.Directory.Exists(imagesFolder))
                    {
                        System.IO.Directory.CreateDirectory(imagesFolder);
                    }

                    string fileName = System.IO.Path.GetFileName(ofd.FileName);
                    string destPath = System.IO.Path.Combine(imagesFolder, fileName);

                    System.IO.File.Copy(ofd.FileName, destPath, true);

                    // Save relative path (e.g. "Images\candle.jpg") into the variable
                    selectedImagePath = System.IO.Path.Combine("Images", fileName);

                    if (picProduct.Image != null)
                    {
                        picProduct.Image.Dispose();
                        picProduct.Image = null;
                    }

                    using (var stream = new System.IO.FileStream(destPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        picProduct.Image = Image.FromStream(stream);
                    }
                }
            }
        }
    }
}
