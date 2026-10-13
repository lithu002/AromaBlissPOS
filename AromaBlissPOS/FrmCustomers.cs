using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AromaBlissPOS
{
    public partial class FrmCustomers : Form
    {
        // 0 = new customer, >0 = update existing customer
        int selectedId = 0;

        public FrmCustomers()
        {
            InitializeComponent();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            // Apply shared theme
            DatabaseHelper.ApplyTheme(this);

            // Force the top header label back to White
            lblTitle.ForeColor = Color.White;

            LoadData();
        }

        // Load all customers into table
        void LoadData()
        {
            dgvCustomers.DataSource = DatabaseHelper.ExecuteQuery(
                "SELECT CustomerID AS [ID], CustomerName AS [Customer Name], ContactNumber AS [Phone], Address AS [Address] " +
                "FROM Customers " +
                "ORDER BY CustomerID DESC;");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validation check
            if (txtCustName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter customer name.");
                return;
            }

            // insert new customer
            if (selectedId == 0)
            {
                DatabaseHelper.ExecuteNonQuery("INSERT INTO Customers (CustomerName, ContactNumber, Address) " +
                    "VALUES ('" + txtCustName.Text + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "');");
            }
            // update selected customer
            else
            {
                DatabaseHelper.ExecuteNonQuery("UPDATE Customers SET CustomerName='" + txtCustName.Text + "', ContactNumber='" + txtPhone.Text + "', Address='" + txtEmail.Text + "' WHERE CustomerID=" + selectedId + ";");
            }

            ClearFields();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Please select a customer first.");
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DatabaseHelper.ExecuteNonQuery("DELETE FROM Customers WHERE CustomerID=" + selectedId + ";");
                ClearFields();
                LoadData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var r = dgvCustomers.Rows[e.RowIndex];
            selectedId = Convert.ToInt32(r.Cells["ID"].Value);
            txtCustName.Text = r.Cells["Customer Name"].Value.ToString();
            txtPhone.Text = r.Cells["ContactNumber"].Value.ToString();
            txtEmail.Text = r.Cells["Address"].Value.ToString();
            btnSave.Text = "Update";
        }

        // Clear textboxes and reset state
        void ClearFields()
        {
            selectedId = 0;
            txtCustName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            btnSave.Text = "Save";
            txtCustName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = DatabaseHelper.ExecuteQuery(
         "SELECT CustomerID AS [ID], CustomerName AS [Customer Name], ContactNumber AS [Phone], Address AS [Address] " +
         "FROM Customers " +
         "WHERE CustomerName LIKE '%" + txtSearch.Text + "%' OR ContactNumber LIKE '%" + txtSearch.Text + "%';");
        }
    }
}
