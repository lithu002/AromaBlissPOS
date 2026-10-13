using System;
using System.Data;
using System.Windows.Forms;

namespace AromaBlissPOS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Creates the database file and tables if they don't exist yet
            DatabaseHelper.InitializeDatabase();

            // Temporary database reset
            /*string resetQuery = @"
               DELETE FROM Categories;
               DELETE FROM Products;
               DELETE FROM Customers;
               DELETE FROM Sales;
               DELETE FROM SaleItems;
               DELETE FROM sqlite_sequence WHERE name IN ('Categories', 'Products', 'Customers', 'Sales', 'SaleItems');";

              DatabaseHelper.ExecuteNonQuery(resetQuery);
            */
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // 1. Validation check
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Query SQLite Users table
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT * FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "';");

            // 3. Grant access if account is found
            if (dt.Rows.Count > 0)
            {
                // Save the logged-in username globally before opening Dashboard
                DatabaseHelper.LoggedInUser = username;

                MessageBox.Show("Login successful! Welcome to AromaBliss POS.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Dashboard
                FrmDashboard dashboard = new FrmDashboard();
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?\n\nThank you for using AromaBliss POS.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}