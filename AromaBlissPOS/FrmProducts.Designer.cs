namespace AromaBlissPOS
{
    partial class FrmProducts
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
            pnlHeader = new Panel();
            btnClose = new Button();
            lblTitle = new Label();
            lblProdName = new Label();
            txtProdName = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvProducts = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            picProduct = new PictureBox();
            btnBrowse = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(44, 52, 55);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1231, 40);
            pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1196, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(26, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(184, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Product Management";
            // 
            // lblProdName
            // 
            lblProdName.AutoSize = true;
            lblProdName.Location = new Point(327, 53);
            lblProdName.Name = "lblProdName";
            lblProdName.Size = new Size(104, 20);
            lblProdName.TabIndex = 1;
            lblProdName.Text = "Product Name";
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(327, 76);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(230, 27);
            txtProdName.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(327, 106);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(327, 129);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(230, 28);
            cmbCategory.TabIndex = 4;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(327, 160);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(80, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price (LKR)";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(327, 183);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(230, 27);
            txtPrice.TabIndex = 6;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(327, 213);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(105, 20);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock Quantity";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(327, 236);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(230, 27);
            txtStock.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(200, 109, 81);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(327, 340);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(230, 35);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(110, 122, 129);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(327, 381);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(230, 35);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gainsboro;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(327, 422);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(230, 35);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(44, 52, 55);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 239, 234);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Location = new Point(574, 87);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(635, 370);
            dgvProducts.TabIndex = 12;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.FromArgb(44, 52, 55);
            lblSearch.Location = new Point(574, 53);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(111, 20);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Search Product:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(691, 51);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 27);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // picProduct
            // 
            picProduct.BorderStyle = BorderStyle.FixedSingle;
            picProduct.Location = new Point(26, 53);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(280, 279);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 15;
            picProduct.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(70, 80, 95);
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(60, 350);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(213, 36);
            btnBrowse.TabIndex = 16;
            btnBrowse.Text = "Browse Image";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // FrmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1231, 483);
            Controls.Add(btnBrowse);
            Controls.Add(picProduct);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvProducts);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtProdName);
            Controls.Add(lblProdName);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProducts";
            Load += FrmProducts_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnClose;
        private Label lblProdName;
        private TextBox txtProdName;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblStock;
        private TextBox txtStock;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
        private Label lblSearch;
        private TextBox txtSearch;
        private PictureBox picProduct;
        private Button btnBrowse;
    }
}