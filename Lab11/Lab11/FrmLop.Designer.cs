namespace Lab11_ClassManager
{
    partial class FrmLop
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();

            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();

            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();

            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.lblTrangThai = new System.Windows.Forms.Label();

            this.grpThongTin.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvLop)).BeginInit();

            this.SuspendLayout();

            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Text = "QUẢN LÝ LỚP HỌC";
            this.lblTieuDe.Location =
                new System.Drawing.Point(20, 15);
            this.lblTieuDe.Size =
                new System.Drawing.Size(800, 45);
            this.lblTieuDe.Font = new System.Drawing.Font(
                "Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor =
                System.Drawing.Color.FromArgb(22, 65, 82);

            // 
            // grpThongTin
            // 
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Text = "Thông tin lớp học";
            this.grpThongTin.Location =
                new System.Drawing.Point(20, 75);
            this.grpThongTin.Size =
                new System.Drawing.Size(900, 180);
            this.grpThongTin.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.grpThongTin.BackColor =
                System.Drawing.Color.White;
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;

            this.grpThongTin.Controls.Add(this.lblMaLop);
            this.grpThongTin.Controls.Add(this.lblTenLop);
            this.grpThongTin.Controls.Add(this.lblKhoa);
            this.grpThongTin.Controls.Add(this.txtMaLop);
            this.grpThongTin.Controls.Add(this.txtTenLop);
            this.grpThongTin.Controls.Add(this.cboKhoa);

            // 
            // lblMaLop
            // 
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Text = "Mã lớp:";
            this.lblMaLop.Location =
                new System.Drawing.Point(25, 40);
            this.lblMaLop.Size =
                new System.Drawing.Size(110, 25);

            // 
            // txtMaLop
            // 
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Location =
                new System.Drawing.Point(145, 36);
            this.txtMaLop.Size =
                new System.Drawing.Size(230, 25);
            this.txtMaLop.MaxLength = 10;
            this.txtMaLop.TabIndex = 0;

            // 
            // lblTenLop
            // 
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Text = "Tên lớp:";
            this.lblTenLop.Location =
                new System.Drawing.Point(25, 90);
            this.lblTenLop.Size =
                new System.Drawing.Size(110, 25);

            // 
            // txtTenLop
            // 
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Location =
                new System.Drawing.Point(145, 86);
            this.txtTenLop.Size =
                new System.Drawing.Size(700, 25);
            this.txtTenLop.MaxLength = 100;
            this.txtTenLop.TabIndex = 1;

            // 
            // lblKhoa
            // 
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Text = "Khoa:";
            this.lblKhoa.Location =
                new System.Drawing.Point(25, 140);
            this.lblKhoa.Size =
                new System.Drawing.Size(110, 25);

            // 
            // cboKhoa
            // 
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Location =
                new System.Drawing.Point(145, 136);
            this.cboKhoa.Size =
                new System.Drawing.Size(400, 27);
            this.cboKhoa.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.TabIndex = 2;

            // 
            // btnThem
            // 
            this.btnThem.Name = "btnThem";
            this.btnThem.Text = "Thêm";
            this.btnThem.Location =
                new System.Drawing.Point(20, 275);
            this.btnThem.Size =
                new System.Drawing.Size(100, 38);
            this.btnThem.TabIndex = 1;
            this.btnThem.UseVisualStyleBackColor = true;

            // 
            // btnSua
            // 
            this.btnSua.Name = "btnSua";
            this.btnSua.Text = "Sửa";
            this.btnSua.Location =
                new System.Drawing.Point(135, 275);
            this.btnSua.Size =
                new System.Drawing.Size(100, 38);
            this.btnSua.TabIndex = 2;
            this.btnSua.UseVisualStyleBackColor = true;

            // 
            // btnXoa
            // 
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location =
                new System.Drawing.Point(250, 275);
            this.btnXoa.Size =
                new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.UseVisualStyleBackColor = true;

            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Location =
                new System.Drawing.Point(365, 275);
            this.btnLamMoi.Size =
                new System.Drawing.Size(110, 38);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.UseVisualStyleBackColor = true;

            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Text = "Tìm mã hoặc tên lớp:";
            this.lblTimKiem.Location =
                new System.Drawing.Point(20, 340);
            this.lblTimKiem.Size =
                new System.Drawing.Size(175, 25);

            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Location =
                new System.Drawing.Point(200, 336);
            this.txtTimKiem.Size =
                new System.Drawing.Size(500, 25);
            this.txtTimKiem.MaxLength = 100;
            this.txtTimKiem.TabIndex = 5;

            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Location =
                new System.Drawing.Point(720, 330);
            this.btnTimKiem.Size =
                new System.Drawing.Size(130, 38);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.UseVisualStyleBackColor = true;

            // 
            // dgvLop
            // 
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Location =
                new System.Drawing.Point(20, 390);
            this.dgvLop.Size =
                new System.Drawing.Size(900, 240);
            this.dgvLop.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.dgvLop.ReadOnly = true;
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.MultiSelect = false;
            this.dgvLop.RowHeadersVisible = false;
            this.dgvLop.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.BackgroundColor =
                System.Drawing.Color.White;
            this.dgvLop.TabIndex = 7;

            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Text = "Chưa tải dữ liệu.";
            this.lblTrangThai.Location =
                new System.Drawing.Point(20, 645);
            this.lblTrangThai.Size =
                new System.Drawing.Size(900, 30);
            this.lblTrangThai.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // 
            // FrmLop
            // 
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize =
                new System.Drawing.Size(940, 690);
            this.MinimumSize =
                new System.Drawing.Size(956, 729);
            this.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor =
                System.Drawing.Color.FromArgb(243, 246, 250);
            this.Name = "FrmLop";
            this.Text = "Lab11 - ADO.NET và CRUD lớp học";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.lblTrangThai);

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvLop)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTin;

        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblKhoa;

        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.ComboBox cboKhoa;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;

        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label lblTrangThai;
    }
}