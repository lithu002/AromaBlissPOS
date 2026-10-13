using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AromaBlissPOS
{
    public partial class FrmSalesHistory : Form
    {
        public FrmSalesHistory()
        {
            InitializeComponent();
        }

        private void FrmSalesHistory_Load(object sender, EventArgs e)
        {
            // Apply shared theme
            DatabaseHelper.ApplyTheme(this);

            // Force the top header label back to White
            lblTitle.ForeColor = Color.White;

            LoadSales();
        }

        // Load all transactions
        void LoadSales()
        {
            dgvSales.DataSource = DatabaseHelper.ExecuteQuery(
                "SELECT s.SaleID AS [Invoice #], s.SaleDate AS [Date], " +
                "COALESCE(c.CustomerName, 'Walk-in') AS [Customer], " +
                "s.TotalAmount AS [Total (LKR)] " +
                "FROM Sales s " +
                "LEFT JOIN Customers c ON s.CustomerID = c.CustomerID " +
                "ORDER BY s.SaleID DESC;");
        }

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int saleId = Convert.ToInt32(dgvSales.Rows[e.RowIndex].Cells["Invoice #"].Value);
            LoadSaleDetails(saleId);
        }

        // Query item breakdown for specific sale
        void LoadSaleDetails(int saleId)
        {
            dgvSaleItems.DataSource = DatabaseHelper.ExecuteQuery(
                "SELECT p.ProductName AS [Product], si.Quantity AS [Qty], " +
                "si.UnitPrice AS [Price], si.LineTotal AS [Total (LKR)] " +
                "FROM SaleItems si " +
                "JOIN Products p ON si.ProductID = p.ProductID " +
                "WHERE si.SaleID = " + saleId + ";");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Filter by exact Invoice ID if a number is typed, otherwise filter by Date
            string whereClause = int.TryParse(txtSearch.Text, out _)
                ? "WHERE s.SaleID = '" + txtSearch.Text + "' "
                : "WHERE s.SaleDate LIKE '%" + txtSearch.Text + "%' ";

            // Refresh table with filtered sales records
            dgvSales.DataSource = DatabaseHelper.ExecuteQuery(
                "SELECT s.SaleID AS [Invoice #], s.SaleDate AS [Date], COALESCE(c.CustomerName, 'Walk-in') AS [Customer], s.TotalAmount AS [Total (LKR)] " +
                "FROM Sales s " +
                "LEFT JOIN Customers c ON s.CustomerID = c.CustomerID " +
                whereClause +
                "ORDER BY s.SaleID DESC;");
        }
        }
    }

