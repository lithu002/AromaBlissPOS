using System;
using System.Data;
using System.Windows.Forms;

namespace AromaBlissPOS
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }


        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            // Display the logged-in username 
            lblHeaderInfo.Text = "Welcome, " + DatabaseHelper.LoggedInUser + " | " + DateTime.Now.ToLongDateString();
            
            LoadMetrics();
            CheckLowStock();
            ApplyDashboardTheme();
        }

        // Fetch live numbers from SQLite
        public void LoadMetrics()
        {
            try
            {
                // 1. Total Products
                DataTable dtProducts = DatabaseHelper.ExecuteQuery("SELECT COUNT(*) FROM Products;");
                if (dtProducts.Rows.Count > 0)
                {
                    lblTotalProducts.Text = dtProducts.Rows[0][0].ToString();
                }

                // 2. Total Categories
                DataTable dtCategories = DatabaseHelper.ExecuteQuery("SELECT COUNT(*) FROM Categories;");
                if (dtCategories.Rows.Count > 0)
                {
                    lblTotalCategories.Text = dtCategories.Rows[0][0].ToString();
                }

                // 3. Today's Revenue
                DataTable dtSales = DatabaseHelper.ExecuteQuery("SELECT IFNULL(SUM(TotalAmount), 0) FROM Sales WHERE Date(SaleDate) = Date('now');");
                if (dtSales.Rows.Count > 0)
                {
                    lblTodaySales.Text = Convert.ToDouble(dtSales.Rows[0][0]).ToString("N2");
                }

                // 4. Load the 5 most recent sales into the DataGridView
                dgvRecentSales.DataSource = DatabaseHelper.ExecuteQuery(
                    "SELECT SaleID AS [Invoice #], SaleDate AS [Date / Time], CustomerID AS [Customer ID], TotalAmount AS [Total (LKR)] FROM Sales ORDER BY SaleID DESC LIMIT 5;");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading metrics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.ShowDialog();
                this.Close();
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
         "Are you sure you want to exit?\n\nThank you for using the POS System.",
         "Exit Confirmation",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCategories catForm = new FrmCategories();
            catForm.ShowDialog();
            this.Show();
            LoadMetrics(); // refresh counts
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmProducts prodForm = new FrmProducts();
            prodForm.ShowDialog();
            this.Show();
            LoadMetrics(); // refresh counts
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCustomers custForm = new FrmCustomers();
            custForm.ShowDialog();
            this.Show();
            LoadMetrics(); // refresh counts
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPOS posForm = new FrmPOS();
            posForm.ShowDialog();
            this.Show();
            LoadMetrics(); // refresh today's sales & count
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSalesHistory histForm = new FrmSalesHistory();
            histForm.ShowDialog();
            this.Show();
            LoadMetrics(); // refresh dashboard totals
        }

        private void dgvRecentSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblLowStock_Click(object sender, EventArgs e)
        {

        }

        void CheckLowStock()
        {
            // Count products with 5 or fewer items remaining
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT COUNT(*) AS [LowCount] FROM Products WHERE StockQuantity <= 5;");
            int count = Convert.ToInt32(dt.Rows[0]["LowCount"]);

            if (count > 0)
            {
                lblLowStock.Text = $"⚠ Alert: {count} product(s) are running low on stock (≤ 5 units)!";
                lblLowStock.BackColor = Color.FromArgb(254, 242, 242); // light red tint
                lblLowStock.ForeColor = Color.Crimson;
            }
            else
            {
                lblLowStock.Text = "✓ Stock Status: All products are sufficiently stocked.";
                lblLowStock.BackColor = Color.FromArgb(240, 253, 244); // light green tint
                lblLowStock.ForeColor = Color.ForestGreen;
            }
        }

        private void FrmDashboard_Activated(object sender, EventArgs e)
        {
            // Re-run metric queries every time you return to the dashboard
            LoadMetrics();
            CheckLowStock();
        }

        // Simple toggle variable
        bool isDark = false;
        private void btnTheme_Click(object sender, EventArgs e)
        {
            // 1. Toggle global state
            DatabaseHelper.IsDarkMode = !DatabaseHelper.IsDarkMode;

            // 2. Apply theme to dashboard
            ApplyDashboardTheme();
        }

        void ApplyDashboardTheme()
        {
            if (DatabaseHelper.IsDarkMode)
            {
                // ================= DARK MODE =================
                this.BackColor = Color.FromArgb(45, 45, 48);
                this.ForeColor = Color.White;

                // Metric Cards Background
                panelCardProducts.BackColor = Color.FromArgb(60, 60, 64);
                panelCardCategories.BackColor = Color.FromArgb(60, 60, 64);
                panelCardSales.BackColor = Color.FromArgb(60, 60, 64);

                // Keep metric values readable in dark mode
                lblTotalProducts.ForeColor = Color.FromArgb(255, 140, 110); // Lighter Terracotta
                lblTotalCategories.ForeColor = Color.White;
                lblTodaySales.ForeColor = Color.FromArgb(100, 220, 100);    // Light Green

                btnClose.ForeColor = Color.White;

                // DataGridView Dark Theme
                dgvRecentSales.BackgroundColor = Color.FromArgb(45, 45, 48);
                dgvRecentSales.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
                dgvRecentSales.DefaultCellStyle.ForeColor = Color.White;
                dgvRecentSales.EnableHeadersVisualStyles = false;
                dgvRecentSales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                dgvRecentSales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                btnTheme.Text = "☀️ Light";
            }
            else
            {
                // ================= ORIGINAL LIGHT MODE =================
                // Form Background (#F9F9FB)
                this.BackColor = Color.FromArgb(249, 249, 251);
                this.ForeColor = Color.FromArgb(44, 52, 55);

                // Metric Cards (Pure White)
                panelCardProducts.BackColor = Color.White;
                panelCardCategories.BackColor = Color.White;
                panelCardSales.BackColor = Color.White;

                // Restoring Original Metric Colors
                lblTotalProducts.ForeColor = Color.FromArgb(200, 109, 81);   // Terracotta
                lblTotalCategories.ForeColor = Color.FromArgb(44, 52, 55);   // Dark Slate
                lblTodaySales.ForeColor = Color.FromArgb(46, 125, 50);       // Forest Green

                btnClose.ForeColor = Color.FromArgb(44, 52, 55);

                // DataGridView Light Theme (Restores natural Windows header style)
                dgvRecentSales.BackgroundColor = Color.White;
                dgvRecentSales.DefaultCellStyle.BackColor = Color.White;
                dgvRecentSales.DefaultCellStyle.ForeColor = Color.FromArgb(44, 52, 55);
                dgvRecentSales.EnableHeadersVisualStyles = true;

                btnTheme.Text = "🌙 Dark";
            }
        }

    }
    
    
    
}
