namespace AromaBlissPOS
{
    partial class FrmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPOS));
            lblTitle = new Label();
            pnlHeader = new Panel();
            btnClose = new Button();
            lblCust = new Label();
            cmbCustomer = new ComboBox();
            lblProd = new Label();
            cmbProduct = new ComboBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblQty = new Label();
            numQty = new NumericUpDown();
            btnAddItem = new Button();
            btnRemoveItem = new Button();
            dgvCart = new DataGridView();
            lblTotalText = new Label();
            lblTotalAmount = new Label();
            btnCheckout = new Button();
            label1 = new Label();
            txtDiscount = new TextBox();
            label2 = new Label();
            txtTax = new TextBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnPrintReceipt = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(162, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "New Sale / Billing";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(44, 52, 55);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(982, 45);
            pnlHeader.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(944, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 33);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblCust
            // 
            lblCust.AutoSize = true;
            lblCust.Location = new Point(30, 60);
            lblCust.Name = "lblCust";
            lblCust.Size = new Size(144, 20);
            lblCust.TabIndex = 3;
            lblCust.Text = "Customer (Optional)";
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(30, 80);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(220, 28);
            cmbCustomer.TabIndex = 4;
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.Location = new Point(270, 60);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(104, 20);
            lblProd.TabIndex = 5;
            lblProd.Text = "Select Product";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(270, 80);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(240, 28);
            cmbProduct.TabIndex = 6;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(530, 60);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(111, 20);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Unit Price (LKR)";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(530, 80);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(110, 27);
            txtPrice.TabIndex = 8;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(660, 60);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(32, 20);
            lblQty.TabIndex = 9;
            lblQty.Text = "Qty";
            // 
            // numQty
            // 
            numQty.Location = new Point(660, 80);
            numQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQty.Name = "numQty";
            numQty.Size = new Size(70, 27);
            numQty.TabIndex = 10;
            numQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(200, 109, 81);
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(750, 78);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(100, 30);
            btnAddItem.TabIndex = 11;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.FromArgb(110, 122, 129);
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(860, 78);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(90, 30);
            btnRemoveItem.TabIndex = 12;
            btnRemoveItem.Text = "Remove";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(243, 239, 234);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCart.Location = new Point(30, 125);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(920, 380);
            dgvCart.TabIndex = 13;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalText.Location = new Point(329, 519);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(202, 28);
            lblTotalText.TabIndex = 14;
            lblTotalText.Text = "Total Amount (LKR):";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.FromArgb(200, 109, 81);
            lblTotalAmount.Location = new Point(421, 545);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(73, 38);
            lblTotalAmount.TabIndex = 15;
            lblTotalAmount.Text = "0.00";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(200, 109, 81);
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(770, 546);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(200, 45);
            btnCheckout.TabIndex = 16;
            btnCheckout.Text = "Complete Sale";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(30, 519);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 17;
            label1.Text = "Discount (%):";
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(153, 516);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(120, 30);
            txtDiscount.TabIndex = 18;
            txtDiscount.Text = "0";
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(30, 564);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 19;
            label2.Text = "Tax (%):";
            // 
            // txtTax
            // 
            txtTax.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTax.Location = new Point(153, 561);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(120, 30);
            txtTax.TabIndex = 20;
            txtTax.Text = "0";
            txtTax.TextChanged += txtTax_TextChanged;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.BackColor = Color.SteelBlue;
            btnPrintReceipt.FlatAppearance.BorderSize = 0;
            btnPrintReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintReceipt.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintReceipt.ForeColor = Color.White;
            btnPrintReceipt.Location = new Point(606, 546);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(158, 45);
            btnPrintReceipt.TabIndex = 21;
            btnPrintReceipt.Text = "Print Receipt";
            btnPrintReceipt.UseVisualStyleBackColor = false;
            btnPrintReceipt.Click += btnPrintReceipt_Click;
            // 
            // FrmPOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 603);
            Controls.Add(btnPrintReceipt);
            Controls.Add(txtTax);
            Controls.Add(label2);
            Controls.Add(txtDiscount);
            Controls.Add(label1);
            Controls.Add(btnCheckout);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblTotalText);
            Controls.Add(dgvCart);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnAddItem);
            Controls.Add(numQty);
            Controls.Add(lblQty);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(cmbProduct);
            Controls.Add(lblProd);
            Controls.Add(cmbCustomer);
            Controls.Add(lblCust);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPOS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPOS";
            Load += FrmPOS_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel pnlHeader;
        private Button btnClose;
        private Label lblCust;
        private ComboBox cmbCustomer;
        private Label lblProd;
        private ComboBox cmbProduct;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblQty;
        private NumericUpDown numQty;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private DataGridView dgvCart;
        private Label lblTotalText;
        private Label lblTotalAmount;
        private Button btnCheckout;
        private Label label1;
        private TextBox txtDiscount;
        private Label label2;
        private TextBox txtTax;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnPrintReceipt;
    }
}