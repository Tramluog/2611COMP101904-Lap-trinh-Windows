namespace Lab06
{
    partial class FrmProduct
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
            this.components = new System.ComponentModel.Container();

            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miManage = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.miReset = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miGuide = new System.Windows.Forms.ToolStripMenuItem();

            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.tsReset = new System.Windows.Forms.ToolStripButton();
            this.tsSearchLabel = new System.Windows.Forms.ToolStripLabel();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.tsSearch = new System.Windows.Forms.ToolStripButton();

            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();

            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();

            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.chkConKinhDoanh = new System.Windows.Forms.CheckBox();

            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();

            this.dgvProducts = new System.Windows.Forms.DataGridView();

            this.contextProducts =
                new System.Windows.Forms.ContextMenuStrip(this.components);

            this.ctxEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxDetails = new System.Windows.Forms.ToolStripMenuItem();

            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus =
                new System.Windows.Forms.ToolStripStatusLabel();

            this.productSource =
                new System.Windows.Forms.BindingSource(this.components);

            this.errorProvider =
                new System.Windows.Forms.ErrorProvider(this.components);

            this.menuMain.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.grpThongTin.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.productSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.errorProvider)).BeginInit();

            this.contextProducts.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();

            // menuMain
            this.menuMain.Name = "menuMain";
            this.menuMain.BackColor = System.Drawing.Color.White;
            this.menuMain.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.miFile,
                    this.miManage,
                    this.miHelp
                });

            // Menu File
            this.miFile.Name = "miFile";
            this.miFile.Text = "File";
            this.miFile.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.miExit
                });

            this.miExit.Name = "miExit";
            this.miExit.Text = "Thoát";

            // Menu Quản lý
            this.miManage.Name = "miManage";
            this.miManage.Text = "Quản lý";
            this.miManage.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.miAdd,
                    this.miEdit,
                    this.miDelete,
                    this.miReset
                });

            this.miAdd.Name = "miAdd";
            this.miAdd.Text = "Thêm sản phẩm";

            this.miEdit.Name = "miEdit";
            this.miEdit.Text = "Sửa sản phẩm";

            this.miDelete.Name = "miDelete";
            this.miDelete.Text = "Xóa sản phẩm";

            this.miReset.Name = "miReset";
            this.miReset.Text = "Làm mới";

            // Menu Trợ giúp
            this.miHelp.Name = "miHelp";
            this.miHelp.Text = "Trợ giúp";
            this.miHelp.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.miGuide
                });

            this.miGuide.Name = "miGuide";
            this.miGuide.Text = "Hướng dẫn sử dụng";

            // toolMain
            this.toolMain.Name = "toolMain";
            this.toolMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolMain.Location = new System.Drawing.Point(20, 36);
            this.toolMain.AutoSize = false;
            this.toolMain.Size = new System.Drawing.Size(1080, 38);
            this.toolMain.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.toolMain.GripStyle =
                System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolMain.BackColor = System.Drawing.Color.White;

            this.toolMain.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.tsAdd,
                    this.tsEdit,
                    this.tsDelete,
                    this.tsReset,
                    this.tsSearchLabel,
                    this.txtTimKiem,
                    this.tsSearch
                });

            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Text = "Thêm";
            this.tsAdd.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Text = "Sửa";
            this.tsEdit.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Text = "Xóa";
            this.tsDelete.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            this.tsReset.Name = "tsReset";
            this.tsReset.Text = "Làm mới";
            this.tsReset.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            this.tsSearchLabel.Name = "tsSearchLabel";
            this.tsSearchLabel.Text = "   Mã / tên sản phẩm:";

            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.AutoSize = false;
            this.txtTimKiem.Size = new System.Drawing.Size(220, 27);

            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Text = "Tìm kiếm";
            this.tsSearch.DisplayStyle =
                System.Windows.Forms.ToolStripItemDisplayStyle.Text;

            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            this.lblTitle.Location = new System.Drawing.Point(20, 86);
            this.lblTitle.Size = new System.Drawing.Size(700, 45);
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(22, 65, 82);

            // grpThongTin
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Text = "Thông tin sản phẩm";
            this.grpThongTin.Location =
                new System.Drawing.Point(20, 145);
            this.grpThongTin.Size =
                new System.Drawing.Size(1080, 260);
            this.grpThongTin.BackColor = System.Drawing.Color.White;
            this.grpThongTin.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;

            this.grpThongTin.Controls.Add(this.lblMaSP);
            this.grpThongTin.Controls.Add(this.lblTenSP);
            this.grpThongTin.Controls.Add(this.lblLoaiSP);
            this.grpThongTin.Controls.Add(this.lblNgayNhap);
            this.grpThongTin.Controls.Add(this.lblDonGia);
            this.grpThongTin.Controls.Add(this.lblSoLuong);

            this.grpThongTin.Controls.Add(this.txtMaSP);
            this.grpThongTin.Controls.Add(this.txtTenSP);
            this.grpThongTin.Controls.Add(this.cboLoaiSP);
            this.grpThongTin.Controls.Add(this.dtpNgayNhap);
            this.grpThongTin.Controls.Add(this.numDonGia);
            this.grpThongTin.Controls.Add(this.numSoLuong);
            this.grpThongTin.Controls.Add(this.chkConKinhDoanh);
            this.grpThongTin.Controls.Add(this.picAnh);
            this.grpThongTin.Controls.Add(this.btnChonAnh);

            // Các Label
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Text = "Mã sản phẩm:";
            this.lblMaSP.Location = new System.Drawing.Point(20, 40);
            this.lblMaSP.Size = new System.Drawing.Size(125, 26);

            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Text = "Tên sản phẩm:";
            this.lblTenSP.Location = new System.Drawing.Point(20, 88);
            this.lblTenSP.Size = new System.Drawing.Size(125, 26);

            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Text = "Loại sản phẩm:";
            this.lblLoaiSP.Location = new System.Drawing.Point(20, 136);
            this.lblLoaiSP.Size = new System.Drawing.Size(125, 26);

            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Text = "Ngày nhập:";
            this.lblNgayNhap.Location = new System.Drawing.Point(20, 184);
            this.lblNgayNhap.Size = new System.Drawing.Size(125, 26);

            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Text = "Đơn giá:";
            this.lblDonGia.Location = new System.Drawing.Point(395, 40);
            this.lblDonGia.Size = new System.Drawing.Size(110, 26);

            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Text = "Số lượng:";
            this.lblSoLuong.Location = new System.Drawing.Point(395, 88);
            this.lblSoLuong.Size = new System.Drawing.Size(110, 26);

            // txtMaSP
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Location = new System.Drawing.Point(150, 36);
            this.txtMaSP.Size = new System.Drawing.Size(210, 25);
            this.txtMaSP.TabIndex = 0;

            // txtTenSP
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Location = new System.Drawing.Point(150, 84);
            this.txtTenSP.Size = new System.Drawing.Size(210, 25);
            this.txtTenSP.TabIndex = 1;

            // cboLoaiSP
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Location = new System.Drawing.Point(150, 132);
            this.cboLoaiSP.Size = new System.Drawing.Size(210, 27);
            this.cboLoaiSP.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSP.TabIndex = 2;

            // dtpNgayNhap
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Location =
                new System.Drawing.Point(150, 180);
            this.dtpNgayNhap.Size = new System.Drawing.Size(210, 25);
            this.dtpNgayNhap.Format =
                System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.TabIndex = 3;

            // numDonGia
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Location = new System.Drawing.Point(510, 36);
            this.numDonGia.Size = new System.Drawing.Size(185, 25);
            this.numDonGia.Minimum = new decimal(
                new int[] { 1000000000, 0, 0, -2147483648 });
            this.numDonGia.Maximum = new decimal(
                new int[] { 1000000000, 0, 0, 0 });
            this.numDonGia.DecimalPlaces = 2;
            this.numDonGia.ThousandsSeparator = true;
            this.numDonGia.TabIndex = 4;

            // numSoLuong
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Location = new System.Drawing.Point(510, 84);
            this.numSoLuong.Size = new System.Drawing.Size(185, 25);
            this.numSoLuong.Minimum = new decimal(
                new int[] { 1000000, 0, 0, -2147483648 });
            this.numSoLuong.Maximum = new decimal(
                new int[] { 1000000, 0, 0, 0 });
            this.numSoLuong.TabIndex = 5;

            // chkConKinhDoanh
            this.chkConKinhDoanh.Name = "chkConKinhDoanh";
            this.chkConKinhDoanh.Text = "Còn kinh doanh";
            this.chkConKinhDoanh.Location =
                new System.Drawing.Point(510, 132);
            this.chkConKinhDoanh.Size =
                new System.Drawing.Size(185, 30);
            this.chkConKinhDoanh.TabIndex = 6;
            this.chkConKinhDoanh.UseVisualStyleBackColor = true;

            // picAnh
            this.picAnh.Name = "picAnh";
            this.picAnh.Location = new System.Drawing.Point(770, 30);
            this.picAnh.Size = new System.Drawing.Size(180, 165);
            this.picAnh.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.BackColor =
                System.Drawing.Color.FromArgb(241, 245, 249);
            this.picAnh.TabStop = false;

            // btnChonAnh
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.Location =
                new System.Drawing.Point(770, 205);
            this.btnChonAnh.Size = new System.Drawing.Size(180, 35);
            this.btnChonAnh.TabIndex = 7;
            this.btnChonAnh.UseVisualStyleBackColor = true;

            // dgvProducts
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Location =
                new System.Drawing.Point(20, 425);
            this.dgvProducts.Size =
                new System.Drawing.Size(1080, 285);
            this.dgvProducts.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.ContextMenuStrip = this.contextProducts;

            // contextProducts
            this.contextProducts.Name = "contextProducts";
            this.contextProducts.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.ctxEdit,
                    this.ctxDelete,
                    this.ctxDetails
                });

            this.ctxEdit.Name = "ctxEdit";
            this.ctxEdit.Text = "Sửa";

            this.ctxDelete.Name = "ctxDelete";
            this.ctxDelete.Text = "Xóa";

            this.ctxDetails.Name = "ctxDetails";
            this.ctxDetails.Text = "Xem chi tiết";

            // statusMain
            this.statusMain.Name = "statusMain";
            this.statusMain.SizingGrip = false;
            this.statusMain.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.lblStatus
                });

            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Sẵn sàng";
            this.lblStatus.Spring = true;
            this.lblStatus.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            // errorProvider
            this.errorProvider.ContainerControl = this;
            this.errorProvider.BlinkStyle =
                System.Windows.Forms.ErrorBlinkStyle.NeverBlink;

            // FrmProduct
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;
            this.BackColor =
                System.Drawing.Color.FromArgb(243, 246, 250);
            this.ClientSize = new System.Drawing.Size(1120, 750);
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FrmProduct";
            this.Text = "Quản lý sản phẩm";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MainMenuStrip = this.menuMain;
            this.KeyPreview = true;

            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.statusMain);

            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.productSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.errorProvider)).EndInit();

            this.contextProducts.ResumeLayout(false);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miManage;
        private System.Windows.Forms.ToolStripMenuItem miAdd;
        private System.Windows.Forms.ToolStripMenuItem miEdit;
        private System.Windows.Forms.ToolStripMenuItem miDelete;
        private System.Windows.Forms.ToolStripMenuItem miReset;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miGuide;

        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripButton tsReset;
        private System.Windows.Forms.ToolStripLabel tsSearchLabel;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripButton tsSearch;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;

        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.CheckBox chkConKinhDoanh;

        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.DataGridView dgvProducts;

        private System.Windows.Forms.ContextMenuStrip contextProducts;
        private System.Windows.Forms.ToolStripMenuItem ctxEdit;
        private System.Windows.Forms.ToolStripMenuItem ctxDelete;
        private System.Windows.Forms.ToolStripMenuItem ctxDetails;

        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;

        private System.Windows.Forms.BindingSource productSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}