namespace AromaBlissPOS
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panelBrand = new Panel();
            lblBrandSubtitle = new Label();
            lblBrandTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            panelBrand.SuspendLayout();
            SuspendLayout();
            // 
            // panelBrand
            // 
            panelBrand.BackColor = Color.FromArgb(62, 42, 53);
            panelBrand.BackgroundImage = (Image)resources.GetObject("panelBrand.BackgroundImage");
            panelBrand.BackgroundImageLayout = ImageLayout.Zoom;
            panelBrand.Controls.Add(lblBrandSubtitle);
            panelBrand.Controls.Add(lblBrandTitle);
            panelBrand.Dock = DockStyle.Left;
            panelBrand.Location = new Point(0, 0);
            panelBrand.Name = "panelBrand";
            panelBrand.Size = new Size(340, 453);
            panelBrand.TabIndex = 0;
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.AutoSize = true;
            lblBrandSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBrandSubtitle.ForeColor = Color.LightGray;
            lblBrandSubtitle.Location = new Point(44, 384);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(236, 23);
            lblBrandSubtitle.TabIndex = 1;
            lblBrandSubtitle.Text = "Artisanal Scents && Fragrances";
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.AutoSize = true;
            lblBrandTitle.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBrandTitle.ForeColor = Color.White;
            lblBrandTitle.Location = new Point(27, 41);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(284, 32);
            lblBrandTitle.TabIndex = 1;
            lblBrandTitle.Text = "AromaBliss Studio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(44, 52, 55);
            label1.Location = new Point(432, 41);
            label1.Name = "label1";
            label1.Size = new Size(266, 38);
            label1.TabIndex = 1;
            label1.Text = "Sign In to Terminal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 140);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(508, 133);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(240, 31);
            txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 221);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(508, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(240, 31);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(200, 109, 81);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(445, 292);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(240, 38);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderColor = Color.LightGray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(80, 80, 80);
            btnExit.Location = new Point(445, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(240, 34);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit Application";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 453);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelBrand);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AromaBliss Studio - POS Login";
            Load += FrmLogin_Load;
            panelBrand.ResumeLayout(false);
            panelBrand.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBrand;
        private Label lblBrandTitle;
        private Label lblBrandSubtitle;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
    }
}
