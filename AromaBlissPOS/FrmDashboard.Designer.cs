namespace AromaBlissPOS
{
    partial class FrmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelSideBar = new Panel();
            btnSalesHistory = new Button();
            btnBilling = new Button();
            btnCustomers = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            btnExit = new Button();
            label2 = new Label();
            label1 = new Label();
            panelTopBar = new Panel();
            btnTheme = new Button();
            lblHeaderInfo = new Label();
            btnClose = new Button();
            panelCardProducts = new Panel();
            lblTotalProducts = new Label();
            label3 = new Label();
            panelCardCategories = new Panel();
            lblTotalCategories = new Label();
            label4 = new Label();
            panelCardSales = new Panel();
            lblTodaySales = new Label();
            label6 = new Label();
            label5 = new Label();
            dgvRecentSales = new DataGridView();
            lblLowStock = new Label();
            panelSideBar.SuspendLayout();
            panelTopBar.SuspendLayout();
            panelCardProducts.SuspendLayout();
            panelCardCategories.SuspendLayout();
            panelCardSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentSales).BeginInit();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.FromArgb(44, 52, 55);
            panelSideBar.Controls.Add(btnSalesHistory);
            panelSideBar.Controls.Add(btnBilling);
            panelSideBar.Controls.Add(btnCustomers);
            panelSideBar.Controls.Add(btnProducts);
            panelSideBar.Controls.Add(btnCategories);
            panelSideBar.Controls.Add(btnExit);
            panelSideBar.Controls.Add(label2);
            panelSideBar.Controls.Add(label1);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(240, 603);
            panelSideBar.TabIndex = 0;
            // 
            // btnSalesHistory
            // 
            btnSalesHistory.BackColor = Color.Transparent;
            btnSalesHistory.FlatAppearance.BorderSize = 0;
            btnSalesHistory.FlatStyle = FlatStyle.Flat;
            btnSalesHistory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalesHistory.ForeColor = Color.White;
            btnSalesHistory.Location = new Point(24, 303);
            btnSalesHistory.Name = "btnSalesHistory";
            btnSalesHistory.Padding = new Padding(15, 0, 0, 0);
            btnSalesHistory.Size = new Size(200, 40);
            btnSalesHistory.TabIndex = 5;
            btnSalesHistory.Text = "Sales History";
            btnSalesHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnSalesHistory.UseVisualStyleBackColor = false;
            btnSalesHistory.Click += btnSalesHistory_Click;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = Color.FromArgb(200, 109, 81);
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBilling.ForeColor = Color.White;
            btnBilling.Location = new Point(24, 257);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(200, 40);
            btnBilling.TabIndex = 4;
            btnBilling.Text = "New Sale / POS";
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.Transparent;
            btnCustomers.FlatAppearance.BorderSize = 0;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(24, 211);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Padding = new Padding(15, 0, 0, 0);
            btnCustomers.Size = new Size(200, 40);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Manage Customers";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.Transparent;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(24, 165);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(15, 0, 0, 0);
            btnProducts.Size = new Size(200, 40);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Manage Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.Transparent;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(24, 119);
            btnCategories.Name = "btnCategories";
            btnCategories.Padding = new Padding(15, 0, 0, 0);
            btnCategories.Size = new Size(200, 40);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "Manage Categories";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(24, 560);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(15, 0, 0, 0);
            btnExit.Size = new Size(200, 40);
            btnExit.TabIndex = 6;
            btnExit.Text = "Logout / Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(46, 60);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Artisanal Fragrances";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(212, 27);
            label1.TabIndex = 1;
            label1.Text = " AromaBliss POS";
            // 
            // panelTopBar
            // 
            panelTopBar.Controls.Add(btnTheme);
            panelTopBar.Controls.Add(lblHeaderInfo);
            panelTopBar.Controls.Add(btnClose);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(240, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(842, 45);
            panelTopBar.TabIndex = 1;
            // 
            // btnTheme
            // 
            btnTheme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTheme.BackColor = SystemColors.ButtonFace;
            btnTheme.Cursor = Cursors.Hand;
            btnTheme.FlatAppearance.BorderColor = Color.Silver;
            btnTheme.FlatStyle = FlatStyle.Flat;
            btnTheme.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTheme.ForeColor = Color.FromArgb(40, 40, 40);
            btnTheme.Location = new Point(683, 7);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(100, 30);
            btnTheme.TabIndex = 8;
            btnTheme.Text = "🌙 Dark";
            btnTheme.UseVisualStyleBackColor = false;
            btnTheme.Click += btnTheme_Click;
            // 
            // lblHeaderInfo
            // 
            lblHeaderInfo.AutoSize = true;
            lblHeaderInfo.ForeColor = Color.DimGray;
            lblHeaderInfo.Location = new Point(12, 15);
            lblHeaderInfo.Name = "lblHeaderInfo";
            lblHeaderInfo.Size = new Size(126, 20);
            lblHeaderInfo.TabIndex = 5;
            lblHeaderInfo.Text = "Welcome, Admin ";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(44, 52, 55);
            btnClose.Location = new Point(804, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // panelCardProducts
            // 
            panelCardProducts.BackColor = Color.White;
            panelCardProducts.Controls.Add(lblTotalProducts);
            panelCardProducts.Controls.Add(label3);
            panelCardProducts.Location = new Point(270, 90);
            panelCardProducts.Name = "panelCardProducts";
            panelCardProducts.Size = new Size(240, 110);
            panelCardProducts.TabIndex = 2;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProducts.ForeColor = Color.FromArgb(200, 109, 81);
            lblTotalProducts.Location = new Point(144, 40);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(43, 50);
            lblTotalProducts.TabIndex = 1;
            lblTotalProducts.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(35, 20);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 0;
            label3.Text = "Total Products";
            // 
            // panelCardCategories
            // 
            panelCardCategories.BackColor = Color.White;
            panelCardCategories.Controls.Add(lblTotalCategories);
            panelCardCategories.Controls.Add(label4);
            panelCardCategories.Location = new Point(535, 90);
            panelCardCategories.Name = "panelCardCategories";
            panelCardCategories.Size = new Size(240, 110);
            panelCardCategories.TabIndex = 3;
            // 
            // lblTotalCategories
            // 
            lblTotalCategories.AutoSize = true;
            lblTotalCategories.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCategories.ForeColor = Color.FromArgb(44, 52, 55);
            lblTotalCategories.Location = new Point(138, 40);
            lblTotalCategories.Name = "lblTotalCategories";
            lblTotalCategories.Size = new Size(43, 50);
            lblTotalCategories.TabIndex = 2;
            lblTotalCategories.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(30, 20);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 1;
            label4.Text = "Active Categories";
            // 
            // panelCardSales
            // 
            panelCardSales.BackColor = Color.White;
            panelCardSales.Controls.Add(lblTodaySales);
            panelCardSales.Controls.Add(label6);
            panelCardSales.Location = new Point(800, 90);
            panelCardSales.Name = "panelCardSales";
            panelCardSales.Size = new Size(240, 110);
            panelCardSales.TabIndex = 4;
            // 
            // lblTodaySales
            // 
            lblTodaySales.AutoSize = true;
            lblTodaySales.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodaySales.ForeColor = Color.FromArgb(46, 125, 50);
            lblTodaySales.Location = new Point(42, 40);
            lblTodaySales.Name = "lblTodaySales";
            lblTodaySales.Size = new Size(95, 50);
            lblTodaySales.TabIndex = 2;
            lblTodaySales.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(18, 20);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 1;
            label6.Text = "Today's Sales (LKR)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(44, 52, 55);
            label5.Location = new Point(252, 248);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 5;
            label5.Text = "Recent Transactions";
            // 
            // dgvRecentSales
            // 
            dgvRecentSales.AllowUserToAddRows = false;
            dgvRecentSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentSales.BackgroundColor = Color.White;
            dgvRecentSales.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 239, 234);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecentSales.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentSales.Location = new Point(270, 282);
            dgvRecentSales.Name = "dgvRecentSales";
            dgvRecentSales.ReadOnly = true;
            dgvRecentSales.RowHeadersVisible = false;
            dgvRecentSales.RowHeadersWidth = 51;
            dgvRecentSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentSales.Size = new Size(770, 268);
            dgvRecentSales.TabIndex = 6;
            dgvRecentSales.CellContentClick += dgvRecentSales_CellContentClick;
            // 
            // lblLowStock
            // 
            lblLowStock.BackColor = Color.FromArgb(254, 242, 242);
            lblLowStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.ForeColor = Color.Crimson;
            lblLowStock.Location = new Point(270, 553);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(770, 32);
            lblLowStock.TabIndex = 7;
            lblLowStock.Text = "Stock Status: Checking...";
            lblLowStock.TextAlign = ContentAlignment.MiddleCenter;
            lblLowStock.Click += lblLowStock_Click;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 251);
            ClientSize = new Size(1082, 603);
            Controls.Add(lblLowStock);
            Controls.Add(dgvRecentSales);
            Controls.Add(label5);
            Controls.Add(panelCardSales);
            Controls.Add(panelCardCategories);
            Controls.Add(panelCardProducts);
            Controls.Add(panelTopBar);
            Controls.Add(panelSideBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AromaBliss Studio - POS Dashboard";
            Activated += FrmDashboard_Activated;
            Load += FrmDashboard_Load;
            panelSideBar.ResumeLayout(false);
            panelSideBar.PerformLayout();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelCardProducts.ResumeLayout(false);
            panelCardProducts.PerformLayout();
            panelCardCategories.ResumeLayout(false);
            panelCardCategories.PerformLayout();
            panelCardSales.ResumeLayout(false);
            panelCardSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSideBar;
        private Label label1;
        private Button btnCategories;
        private Label label2;
        private Button btnExit;
        private Button btnSalesHistory;
        private Button btnBilling;
        private Button btnCustomers;
        private Button btnProducts;
        private Panel panelTopBar;
        private Button btnClose;
        private Panel panelCardProducts;
        private Label lblTotalProducts;
        private Label label3;
        private Panel panelCardCategories;
        private Label lblTotalCategories;
        private Label label4;
        private Panel panelCardSales;
        private Label lblTodaySales;
        private Label label6;
        private Label lblHeaderInfo;
        private Label label5;
        private DataGridView dgvRecentSales;
        private Label lblLowStock;
        private Button btnTheme;
    }
}