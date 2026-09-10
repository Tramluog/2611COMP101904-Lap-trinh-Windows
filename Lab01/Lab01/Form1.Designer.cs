namespace Lab01
{
    partial class Form1
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
            lblTieuDe = new Label();
            lblHoTen = new Label();
            lblNamSinh = new Label();
            lblEmail = new Label();
            txtHoTen = new TextBox();
            txtNamSinh = new TextBox();
            txtEmail = new TextBox();
            grpGioiTinh = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            lblKhoa = new Label();
            cboKhoa = new ComboBox();
            btnHienThi = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtKetQua = new TextBox();
            grpGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(311, 19);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(165, 20);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "THÔNG TIN SINH VIÊN ";
            lblTieuDe.Click += label1_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(33, 54);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(76, 20);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ và tên:";
            lblHoTen.Click += label2_Click;
            // 
            // lblNamSinh
            // 
            lblNamSinh.AutoSize = true;
            lblNamSinh.Location = new Point(33, 107);
            lblNamSinh.Name = "lblNamSinh";
            lblNamSinh.Size = new Size(74, 20);
            lblNamSinh.TabIndex = 2;
            lblNamSinh.Text = "Năm sinh:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(447, 119);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(115, 51);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(206, 27);
            txtHoTen.TabIndex = 4;
            // 
            // txtNamSinh
            // 
            txtNamSinh.Location = new Point(115, 104);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(206, 27);
            txtNamSinh.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(529, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 27);
            txtEmail.TabIndex = 6;
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(radNu);
            grpGioiTinh.Controls.Add(radNam);
            grpGioiTinh.Location = new Point(33, 159);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(298, 86);
            grpGioiTinh.TabIndex = 7;
            grpGioiTinh.TabStop = false;
            grpGioiTinh.Text = "Nhóm giới tính";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(19, 56);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 1;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(19, 26);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 0;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(446, 58);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(77, 20);
            lblKhoa.TabIndex = 8;
            lblKhoa.Text = "Khoa/Lớp:";
            lblKhoa.Click += lblKhoa_Click;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(529, 54);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(205, 28);
            cboKhoa.TabIndex = 9;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(429, 216);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 10;
            btnHienThi.Text = "Hiển thị";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(556, 216);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(677, 216);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(209, 292);
            txtKetQua.Multiline = true;
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(398, 132);
            txtKetQua.TabIndex = 13;
            txtKetQua.Text = "Hiển thị kết quả";
            txtKetQua.TextChanged += txtKetQua_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtKetQua);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnHienThi);
            Controls.Add(cboKhoa);
            Controls.Add(lblKhoa);
            Controls.Add(grpGioiTinh);
            Controls.Add(txtEmail);
            Controls.Add(txtNamSinh);
            Controls.Add(txtHoTen);
            Controls.Add(lblEmail);
            Controls.Add(lblNamSinh);
            Controls.Add(lblHoTen);
            Controls.Add(lblTieuDe);
            Name = "Form1";
            Text = "Chọn khoa/lớp";
            Load += Form1_Load;
            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblHoTen;
        private Label lblNamSinh;
        private Label lblEmail;
        private TextBox txtHoTen;
        private TextBox txtNamSinh;
        private TextBox txtEmail;
        private GroupBox grpGioiTinh;
        private RadioButton radNu;
        private RadioButton radNam;
        private Label lblKhoa;
        private ComboBox cboKhoa;
        private Button btnHienThi;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtKetQua;
    }
}
