namespace ShopManagerMini.Forms
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.lblTitle.Location = new System.Drawing.Point(25, 25);
            this.lblTitle.Size = new System.Drawing.Size(450, 45);
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(22, 65, 82);
            this.lblTitle.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // lblUsername
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Text = "Tên đăng nhập:";
            this.lblUsername.Location = new System.Drawing.Point(35, 105);
            this.lblUsername.Size = new System.Drawing.Size(140, 28);

            // lblPassword
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Text = "Mật khẩu:";
            this.lblPassword.Location = new System.Drawing.Point(35, 158);
            this.lblPassword.Size = new System.Drawing.Size(140, 28);

            // txtUsername
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Location = new System.Drawing.Point(185, 102);
            this.txtUsername.Size = new System.Drawing.Size(275, 27);
            this.txtUsername.TabIndex = 0;

            // txtPassword
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Location = new System.Drawing.Point(185, 155);
            this.txtPassword.Size = new System.Drawing.Size(275, 27);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TabIndex = 1;

            // btnLogin
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Location = new System.Drawing.Point(185, 220);
            this.btnLogin.Size = new System.Drawing.Size(130, 42);
            this.btnLogin.BackColor =
                System.Drawing.Color.FromArgb(15, 118, 110);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.TabIndex = 2;
            this.btnLogin.UseVisualStyleBackColor = false;

            // btnExit
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "Thoát";
            this.btnExit.Location = new System.Drawing.Point(330, 220);
            this.btnExit.Size = new System.Drawing.Size(130, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = true;

            // FrmLogin
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor =
                System.Drawing.Color.FromArgb(243, 246, 250);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmLogin";
            this.Text = "Đăng nhập - ShopManagerMini";

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
    }
}