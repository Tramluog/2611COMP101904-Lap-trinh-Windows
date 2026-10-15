namespace ShopManagerMini.Forms
{
    partial class FrmAbout
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Tiêu đề
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "SHOP MANAGER MINI";
            this.lblTitle.Location = new System.Drawing.Point(25, 25);
            this.lblTitle.Size = new System.Drawing.Size(550, 45);
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(22, 65, 82);
            this.lblTitle.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Mô tả
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text =
                "Ứng dụng quản lý cửa hàng mini bằng C# Windows Forms";
            this.lblDescription.Location =
                new System.Drawing.Point(25, 85);
            this.lblDescription.Size =
                new System.Drawing.Size(550, 45);
            this.lblDescription.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // Thông tin sinh viên
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Text =
                "Học phần: 2611COMP101904 - Lập trình Windows\r\n\r\n" +
                "Họ và tên: [Điền họ tên]\r\n\r\n" +
                "MSSV: [Điền MSSV]\r\n\r\n" +
                "Lớp: [Điền lớp]\r\n\r\n" +
                "Nhóm: [Điền nhóm]";
            this.lblInfo.Location =
                new System.Drawing.Point(45, 145);
            this.lblInfo.Size =
                new System.Drawing.Size(510, 220);

            // Nút đóng
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "Đóng";
            this.btnClose.Location =
                new System.Drawing.Point(240, 385);
            this.btnClose.Size =
                new System.Drawing.Size(120, 38);
            this.btnClose.TabIndex = 0;

            // Form
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor =
                System.Drawing.Color.FromArgb(243, 246, 250);
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmAbout";
            this.Text = "Giới thiệu";

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClose);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnClose;
    }
}