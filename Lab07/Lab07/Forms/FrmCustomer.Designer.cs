namespace ShopManagerMini.Forms
{
    partial class FrmCustomer
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
            this.grpInfo = new System.Windows.Forms.GroupBox();

            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLoaiKH = new System.Windows.Forms.Label();

            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.cboLoaiKH = new System.Windows.Forms.ComboBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();

            this.dgvCustomers =
                new System.Windows.Forms.DataGridView();

            this.lblCount = new System.Windows.Forms.Label();

            this.grpInfo.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvCustomers)).BeginInit();

            this.SuspendLayout();

            // Tiêu đề
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(760, 45);
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(22, 65, 82);

            // GroupBox
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Text = "Thông tin khách hàng";
            this.grpInfo.Location = new System.Drawing.Point(20, 70);
            this.grpInfo.Size = new System.Drawing.Size(860, 150);
            this.grpInfo.BackColor = System.Drawing.Color.White;
            this.grpInfo.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.grpInfo.TabIndex = 0;

            this.grpInfo.Controls.Add(this.lblMaKH);
            this.grpInfo.Controls.Add(this.lblHoTen);
            this.grpInfo.Controls.Add(this.lblPhone);
            this.grpInfo.Controls.Add(this.lblLoaiKH);
            this.grpInfo.Controls.Add(this.txtMaKH);
            this.grpInfo.Controls.Add(this.txtHoTen);
            this.grpInfo.Controls.Add(this.txtSoDienThoai);
            this.grpInfo.Controls.Add(this.cboLoaiKH);

            // Nhãn
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Text = "Mã khách hàng:";
            this.lblMaKH.Location = new System.Drawing.Point(20, 40);
            this.lblMaKH.Size = new System.Drawing.Size(140, 25);

            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Text = "Họ tên:";
            this.lblHoTen.Location = new System.Drawing.Point(20, 92);
            this.lblHoTen.Size = new System.Drawing.Size(140, 25);

            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Text = "Số điện thoại:";
            this.lblPhone.Location = new System.Drawing.Point(440, 40);
            this.lblPhone.Size = new System.Drawing.Size(135, 25);

            this.lblLoaiKH.Name = "lblLoaiKH";
            this.lblLoaiKH.Text = "Loại khách hàng:";
            this.lblLoaiKH.Location = new System.Drawing.Point(440, 92);
            this.lblLoaiKH.Size = new System.Drawing.Size(145, 25);

            // Ô nhập
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Location = new System.Drawing.Point(165, 36);
            this.txtMaKH.Size = new System.Drawing.Size(240, 25);
            this.txtMaKH.TabIndex = 0;

            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Location = new System.Drawing.Point(165, 88);
            this.txtHoTen.Size = new System.Drawing.Size(240, 25);
            this.txtHoTen.TabIndex = 1;

            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Location =
                new System.Drawing.Point(590, 36);
            this.txtSoDienThoai.Size =
                new System.Drawing.Size(240, 25);
            this.txtSoDienThoai.TabIndex = 2;

            this.cboLoaiKH.Name = "cboLoaiKH";
            this.cboLoaiKH.Location =
                new System.Drawing.Point(590, 88);
            this.cboLoaiKH.Size = new System.Drawing.Size(240, 27);
            this.cboLoaiKH.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKH.TabIndex = 3;

            // Nút
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "Thêm khách hàng";
            this.btnAdd.Location = new System.Drawing.Point(20, 237);
            this.btnAdd.Size = new System.Drawing.Size(160, 38);
            this.btnAdd.TabIndex = 1;

            this.btnReset.Name = "btnReset";
            this.btnReset.Text = "Làm mới";
            this.btnReset.Location = new System.Drawing.Point(195, 237);
            this.btnReset.Size = new System.Drawing.Size(120, 38);
            this.btnReset.TabIndex = 2;

            // Bảng
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Location =
                new System.Drawing.Point(20, 295);
            this.dgvCustomers.Size =
                new System.Drawing.Size(860, 245);
            this.dgvCustomers.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.TabIndex = 3;

            // Số lượng
            this.lblCount.Name = "lblCount";
            this.lblCount.Text = "Tổng số khách hàng:";
            this.lblCount.Location = new System.Drawing.Point(20, 550);
            this.lblCount.Size = new System.Drawing.Size(600, 25);
            this.lblCount.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            // Form
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.MinimumSize = new System.Drawing.Size(916, 629);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor =
                System.Drawing.Color.FromArgb(243, 246, 250);
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmCustomer";
            this.Text = "Quản lý khách hàng";

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.lblCount);

            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvCustomers)).EndInit();

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInfo;

        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLoaiKH;

        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.ComboBox cboLoaiKH;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblCount;
    }
}