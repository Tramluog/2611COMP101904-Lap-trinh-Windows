namespace ShopManagerMini.Forms
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

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();

            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();

            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();

            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.lblCount = new System.Windows.Forms.Label();

            this.grpInfo.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.dgvProducts)).BeginInit();

            this.SuspendLayout();

            // Tiêu đề
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "QUẢN LÝ SẢN PHẨM";
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Size = new System.Drawing.Size(700, 45);
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(22, 65, 82);

            // Nhóm thông tin
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Text = "Thông tin sản phẩm";
            this.grpInfo.Location = new System.Drawing.Point(20, 70);
            this.grpInfo.Size = new System.Drawing.Size(920, 180);
            this.grpInfo.BackColor = System.Drawing.Color.White;
            this.grpInfo.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.grpInfo.TabIndex = 0;

            this.grpInfo.Controls.Add(this.lblMaSP);
            this.grpInfo.Controls.Add(this.lblTenSP);
            this.grpInfo.Controls.Add(this.lblLoaiSP);
            this.grpInfo.Controls.Add(this.lblDonGia);
            this.grpInfo.Controls.Add(this.lblSoLuong);
            this.grpInfo.Controls.Add(this.txtMaSP);
            this.grpInfo.Controls.Add(this.txtTenSP);
            this.grpInfo.Controls.Add(this.cboLoaiSP);
            this.grpInfo.Controls.Add(this.numDonGia);
            this.grpInfo.Controls.Add(this.numSoLuong);

            // Nhãn
            this.lblMaSP.Text = "Mã sản phẩm:";
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Location = new System.Drawing.Point(20, 38);
            this.lblMaSP.Size = new System.Drawing.Size(130, 25);

            this.lblTenSP.Text = "Tên sản phẩm:";
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Location = new System.Drawing.Point(20, 84);
            this.lblTenSP.Size = new System.Drawing.Size(130, 25);

            this.lblLoaiSP.Text = "Loại sản phẩm:";
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Location = new System.Drawing.Point(20, 130);
            this.lblLoaiSP.Size = new System.Drawing.Size(130, 25);

            this.lblDonGia.Text = "Đơn giá:";
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Location = new System.Drawing.Point(470, 38);
            this.lblDonGia.Size = new System.Drawing.Size(110, 25);

            this.lblSoLuong.Text = "Số lượng:";
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Location = new System.Drawing.Point(470, 84);
            this.lblSoLuong.Size = new System.Drawing.Size(110, 25);

            // Ô nhập
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Location = new System.Drawing.Point(160, 34);
            this.txtMaSP.Size = new System.Drawing.Size(260, 25);
            this.txtMaSP.TabIndex = 0;

            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Location = new System.Drawing.Point(160, 80);
            this.txtTenSP.Size = new System.Drawing.Size(260, 25);
            this.txtTenSP.TabIndex = 1;

            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Location = new System.Drawing.Point(160, 126);
            this.cboLoaiSP.Size = new System.Drawing.Size(260, 27);
            this.cboLoaiSP.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSP.TabIndex = 2;

            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Location = new System.Drawing.Point(590, 34);
            this.numDonGia.Size = new System.Drawing.Size(270, 25);
            this.numDonGia.Maximum = new decimal(
                new int[] { 1000000000, 0, 0, 0 });
            this.numDonGia.DecimalPlaces = 2;
            this.numDonGia.ThousandsSeparator = true;
            this.numDonGia.TabIndex = 3;

            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Location = new System.Drawing.Point(590, 80);
            this.numSoLuong.Size = new System.Drawing.Size(270, 25);
            this.numSoLuong.Maximum = new decimal(
                new int[] { 1000000, 0, 0, 0 });
            this.numSoLuong.TabIndex = 4;

            // Nút lệnh
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Location = new System.Drawing.Point(20, 267);
            this.btnAdd.Size = new System.Drawing.Size(100, 36);
            this.btnAdd.TabIndex = 1;

            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Location = new System.Drawing.Point(130, 267);
            this.btnEdit.Size = new System.Drawing.Size(100, 36);
            this.btnEdit.TabIndex = 2;

            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Location = new System.Drawing.Point(240, 267);
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 3;

            this.btnReset.Name = "btnReset";
            this.btnReset.Text = "Làm mới";
            this.btnReset.Location = new System.Drawing.Point(350, 267);
            this.btnReset.Size = new System.Drawing.Size(100, 36);
            this.btnReset.TabIndex = 4;

            // Tìm kiếm
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Mã / tên:";
            this.lblSearch.Location = new System.Drawing.Point(475, 274);
            this.lblSearch.Size = new System.Drawing.Size(85, 25);

            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Location = new System.Drawing.Point(565, 271);
            this.txtSearch.Size = new System.Drawing.Size(245, 25);
            this.txtSearch.TabIndex = 5;

            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Location = new System.Drawing.Point(825, 267);
            this.btnSearch.Size = new System.Drawing.Size(115, 36);
            this.btnSearch.TabIndex = 6;

            // Bảng
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Location =
                new System.Drawing.Point(20, 320);
            this.dgvProducts.Size =
                new System.Drawing.Size(920, 270);
            this.dgvProducts.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.TabIndex = 7;

            // Số lượng
            this.lblCount.Name = "lblCount";
            this.lblCount.Text = "Số sản phẩm:";
            this.lblCount.Location = new System.Drawing.Point(20, 600);
            this.lblCount.Size = new System.Drawing.Size(600, 25);
            this.lblCount.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            // Form
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(960, 640);
            this.MinimumSize = new System.Drawing.Size(976, 679);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BackColor =
                System.Drawing.Color.FromArgb(243, 246, 250);
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmProduct";
            this.Text = "Quản lý sản phẩm";

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lblCount);

            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)
                (this.dgvProducts)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;

        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.NumericUpDown numSoLuong;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblCount;
    }
}