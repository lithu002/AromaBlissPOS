using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace AromaBlissPOS
{
    // SQLite database manager
    public static class DatabaseHelper
    {
        // 1. Database connection path
        public static string ConnectionString = "Data Source=AromaBlissPOS.db;Version=3;";


        // Global flag for theme (accessible from any form)
        public static bool IsDarkMode = false;


        // Stores the currently logged-in username globally
        public static string LoggedInUser = "Admin";


        // 2. Create tables automatically if they don't exist
        public static void InitializeDatabase()
        {
            using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                string query = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT UNIQUE NOT NULL,
                    Password TEXT NOT NULL
                );

                INSERT OR REPLACE INTO Users (UserID, Username, Password) VALUES (1, 'owner', '1234');
                INSERT OR REPLACE INTO Users (UserID, Username, Password) VALUES (2, 'cashier', '1234');
                INSERT OR REPLACE INTO Users (UserID, Username, Password) VALUES (3, 'operator', '1234');
                INSERT OR REPLACE INTO Users (UserID, Username, Password) VALUES (4, 'admin', '1234');

                CREATE TABLE IF NOT EXISTS Categories (
                    CategoryID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CategoryName TEXT NOT NULL,
                    Description TEXT
                );

                CREATE TABLE IF NOT EXISTS Products (
                    ProductID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductName TEXT NOT NULL,
                    CategoryID INTEGER NOT NULL,
                    UnitPrice REAL NOT NULL,
                    StockQuantity INTEGER NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Customers (
                    CustomerID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CustomerName TEXT NOT NULL,
                    ContactNumber TEXT,
                    Address TEXT
                );

                CREATE TABLE IF NOT EXISTS Sales (
                    SaleID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SaleDate TEXT NOT NULL,
                    CustomerID INTEGER,
                    TotalAmount REAL NOT NULL
                );

                CREATE TABLE IF NOT EXISTS SaleItems (
                    SaleItemID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SaleID INTEGER NOT NULL,
                    ProductID INTEGER NOT NULL,
                    Quantity INTEGER NOT NULL,
                    UnitPrice REAL NOT NULL,
                    LineTotal REAL NOT NULL
                );";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 3. For INSERT, UPDATE, DELETE
        public static void ExecuteNonQuery(string query)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // 4. For SELECT (Loading data into DataGridView)
        public static DataTable ExecuteQuery(string query)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Applies consistent Theme across any form and its controls
        public static void ApplyTheme(Form frm)
        {
            Color bg = IsDarkMode ? Color.FromArgb(55, 65, 75) : Color.FromArgb(249, 249, 251);
            Color fg = IsDarkMode ? Color.White : Color.FromArgb(44, 52, 55);

            frm.BackColor = bg;
            frm.ForeColor = fg;

            // Recolor all direct controls and nested controls (inside Panels/GroupBoxes)
            UpdateControlColors(frm, bg, fg);
        }

        private static void UpdateControlColors(Control parent, Color bg, Color fg)
        {
            foreach (Control c in parent.Controls)
            {
                // Change text colors for readable elements
                if (c is Label || c is GroupBox || c is CheckBox || c is RadioButton)
                {
                    c.ForeColor = fg;
                }
                else if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = IsDarkMode ? Color.FromArgb(45, 45, 48) : Color.White;
                    dgv.DefaultCellStyle.BackColor = IsDarkMode ? Color.FromArgb(45, 45, 48) : Color.White;
                    dgv.DefaultCellStyle.ForeColor = fg;
                    dgv.EnableHeadersVisualStyles = !IsDarkMode;
                    if (IsDarkMode)
                    {
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    }
                }

                // Recursively check inside Panels / GroupBoxes
                if (c.HasChildren)
                {
                    UpdateControlColors(c, bg, fg);
                }
            }
        }
    }
}