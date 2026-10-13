using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AromaBlissPOS
{
    public partial class FrmCategories : Form
    {
        // 0 = new record, >0 = update existing record
        private int selectedId = 0;

        public FrmCategories()
        {
            InitializeComponent();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            // Apply shared theme
            DatabaseHelper.ApplyTheme(this);

            // Force the top header label back to White
            lblTitle.ForeColor = Color.White;

            LoadData();
        }

        // Load all categories into grid
        private void LoadData()
        {
            dgvCategories.DataSource = DatabaseHelper.ExecuteQuery(
                "SELECT CategoryID AS [ID], CategoryName AS [Category], Description FROM Categories ORDER BY CategoryID DESC;");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validation check
            if (txtCatName.Text == "")
            {
                MessageBox.Show("Please enter category name.");
                return;
            }

            // insert if new
            if (selectedId == 0)
            {
                DatabaseHelper.ExecuteNonQuery("INSERT INTO Categories (CategoryName, Description) VALUES ('" + txtCatName.Text + "', '" + txtDescription.Text + "');");
            }
            // update if already selected
            else
            {
                DatabaseHelper.ExecuteNonQuery("UPDATE Categories SET CategoryName='" + txtCatName.Text + "', Description='" + txtDescription.Text + "' WHERE CategoryID=" + selectedId + ";");
            }

            ClearFields();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a category first.");
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                DatabaseHelper.ExecuteNonQuery("DELETE FROM Categories WHERE CategoryID=" + selectedId + ";");
                ClearFields();
                LoadData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var r = dgvCategories.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(r.Cells[0].Value);
            txtCatName.Text = r.Cells[1].Value.ToString();
            txtDescription.Text = r.Cells[2].Value.ToString();
            btnSave.Text = "Update";
        }

        // Clear textboxes and reset state
        void ClearFields()
        {
            selectedId = 0;
            txtCatName.Text = "";
            txtDescription.Text = "";
            btnSave.Text = "Save";
            txtCatName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
