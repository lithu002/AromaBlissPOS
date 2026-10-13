using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AromaBlissPOS
{
    public partial class FrmPOS : Form
    {
        // cart data source
        DataTable cartTable = new DataTable();

        public FrmPOS()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            int custId = Convert.ToInt32(cmbCustomer.SelectedValue);
            string dateStr = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            decimal grandTotal = Convert.ToDecimal(lblTotalAmount.Text);

            // 1. insert sale record
            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO Sales (SaleDate, CustomerID, TotalAmount) " +
                "VALUES ('" + dateStr + "', " + custId + ", " + grandTotal + ");");

            // 2. get latest sale ID
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT MAX(SaleID) AS LastID FROM Sales;");
            int saleId = Convert.ToInt32(dt.Rows[0]["LastID"]);

            // 3. insert each item & deduct stock
            foreach (DataRow r in cartTable.Rows)
            {
                int pId = Convert.ToInt32(r["ProductID"]);
                int qty = Convert.ToInt32(r["Qty"]);
                decimal price = Convert.ToDecimal(r["Unit Price"]);
                decimal lineTot = Convert.ToDecimal(r["Line Total"]);

                DatabaseHelper.ExecuteNonQuery(
                    "INSERT INTO SaleItems (SaleID, ProductID, Quantity, UnitPrice, LineTotal) " +
                    "VALUES (" + saleId + ", " + pId + ", " + qty + ", " + price + ", " + lineTot + ");");

                DatabaseHelper.ExecuteNonQuery(
                    "UPDATE Products SET StockQuantity = StockQuantity - " + qty + " WHERE ProductID = " + pId + ";");
            }

            MessageBox.Show("Sale completed successfully! Total: LKR " + grandTotal.ToString("0.00"));
            this.Close();
        }

        private void FrmPOS_Load(object sender, EventArgs e)
        {
            // Execute each delete as an individual query
           /* DatabaseHelper.ExecuteNonQuery("DELETE FROM SaleItems;");
            DatabaseHelper.ExecuteNonQuery("DELETE FROM Sales;");
            DatabaseHelper.ExecuteNonQuery("DELETE FROM sqlite_sequence WHERE name='Sales';");
            DatabaseHelper.ExecuteNonQuery("DELETE FROM sqlite_sequence WHERE name='SaleItems';");
           */

            // Apply shared theme
            DatabaseHelper.ApplyTheme(this);

            // Force the top header label back to White
            lblTitle.ForeColor = Color.White;

            SetupCartTable();
            LoadCustomers();
            LoadProducts();
        }

        // Setup cart columns
        void SetupCartTable()
        {
            cartTable.Columns.Add("ProductID", typeof(int));
            cartTable.Columns.Add("Product", typeof(string));
            cartTable.Columns.Add("Unit Price", typeof(decimal));
            cartTable.Columns.Add("Qty", typeof(int));
            cartTable.Columns.Add("Line Total", typeof(decimal));

            dgvCart.DataSource = cartTable;

            if (dgvCart.Columns["ProductID"] != null)
            {
                dgvCart.Columns["ProductID"].Visible = false;
            }
        }

        // Load customer dropdown
        void LoadCustomers()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT CustomerID, CustomerName FROM Customers;");

            // add walk-in default option
            DataRow row = dt.NewRow();
            row["CustomerID"] = 0;
            row["CustomerName"] = "-- Walk-in Customer --";
            dt.Rows.InsertAt(row, 0);

            cmbCustomer.DataSource = dt;
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerID";
        }

        //  Load product dropdown
        void LoadProducts()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT ProductID, ProductName, UnitPrice, StockQuantity FROM Products WHERE StockQuantity > 0;");
            cmbProduct.DataSource = dt;
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";

            if (dt.Rows.Count > 0)
            {
                txtPrice.Text = dt.Rows[0]["UnitPrice"].ToString();
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem != null && cmbProduct.SelectedItem is DataRowView)
            {
                DataRowView row = (DataRowView)cmbProduct.SelectedItem;
                txtPrice.Text = row["UnitPrice"].ToString();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem == null || string.IsNullOrEmpty(txtPrice.Text)) return;

            int prodId = Convert.ToInt32(cmbProduct.SelectedValue);
            string prodName = cmbProduct.Text;
            decimal unitPrice = Convert.ToDecimal(txtPrice.Text);
            int qty = (int)numQty.Value;

            // Read stock directly from selected dropdown item
            DataRowView selectedRow = (DataRowView)cmbProduct.SelectedItem;
            int stock = Convert.ToInt32(selectedRow["StockQuantity"]);

            if (qty > stock)
            {
                MessageBox.Show("Cannot add item. Only " + stock + " items available in stock.");
                return;
            }

            // check if product already in cart
            foreach (DataRow r in cartTable.Rows)
            {
                if ((int)r["ProductID"] == prodId)
                {
                    r["Qty"] = (int)r["Qty"] + qty;
                    r["Line Total"] = (int)r["Qty"] * unitPrice;
                    CalculateTotal();
                    return;
                }
            }

            // add new line
            cartTable.Rows.Add(prodId, prodName, unitPrice, qty, unitPrice * qty);
            CalculateTotal();

            // Lock customer dropdown here
            cmbCustomer.Enabled = false;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                dgvCart.Rows.RemoveAt(dgvCart.SelectedRows[0].Index);
                CalculateTotal();

                // Unlock customer dropdown if all items have been removed
                if (cartTable.Rows.Count == 0)
                {
                    cmbCustomer.Enabled = true;
                }
            }
        }

        // Calculate total with discount & tax
        void CalculateTotal()
        {
            decimal sum = 0;
            foreach (DataRow r in cartTable.Rows)
            {
                sum = sum + Convert.ToDecimal(r["Line Total"]);
            }

            // Read discount percentage
            decimal discountPercent = 0;
            if (txtDiscount.Text != "")
            {
                discountPercent = Convert.ToDecimal(txtDiscount.Text);
            }

            // Read tax percentage
            decimal taxPercent = 0;
            if (txtTax.Text != "")
            {
                taxPercent = Convert.ToDecimal(txtTax.Text);
            }

            // Calculate discount amount and taxable amount
            decimal discountAmount = sum * (discountPercent / 100);
            decimal afterDiscount = sum - discountAmount;

            // Calculate tax amount and final grand total
            decimal taxAmount = afterDiscount * (taxPercent / 100);
            decimal grandTotal = afterDiscount + taxAmount;

            // Display result
            lblTotalAmount.Text = grandTotal.ToString("0.00");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // 1. Build receipt text
            string receipt = "        AROMABLISS POS        \n";
            receipt += "--------------------------------\n";
            receipt += "Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "\n";
            receipt += "Cashier: " + DatabaseHelper.LoggedInUser + "\n";
            receipt += "Customer: " + cmbCustomer.Text + "\n";
            receipt += "--------------------------------\n";

            // 2. Add items (limit long names so they don't get cut off)
            foreach (DataRow r in cartTable.Rows)
            {
                string pName = r["Product"].ToString();
                if (pName.Length > 15)
                {
                    pName = pName.Substring(0, 13) + "..";
                }

                receipt += pName + " x" + r["Qty"] + " = " + r["Line Total"] + "\n";
            }

            // 3. Add totals
            receipt += "--------------------------------\n";
            receipt += "Discount: " + txtDiscount.Text + "%\n";
            receipt += "Tax: " + txtTax.Text + "%\n";
            receipt += "TOTAL: LKR " + lblTotalAmount.Text + "\n";
            receipt += "--------------------------------\n";
            receipt += "     Thank you! Come again!     \n";

            // 4. Print clean text
            Font font = new Font("Courier New", 12, FontStyle.Bold);
            e.Graphics.DrawString(receipt, font, Brushes.Black, 20, 20);
        }
        
        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            // Size the preview window and set zoom to fit perfectly
            printPreviewDialog1.Size = new Size(600, 700);
            printPreviewDialog1.PrintPreviewControl.Zoom = 0.75;
            printPreviewDialog1.ShowDialog();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
