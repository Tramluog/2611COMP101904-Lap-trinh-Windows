using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lab06
{
    public partial class FrmProduct : Form
    {
        private readonly BindingList<Product> products =
            new BindingList<Product>();

        private readonly CultureInfo vi =
            CultureInfo.GetCultureInfo("vi-VN");

        private Product selectedProduct;
        private string imagePath = "";
        private string searchKeyword = "";
        private bool refreshingGrid;

        public FrmProduct()
        {
            InitializeComponent();

            ConfigureGrid();
            ConnectEvents();
        }

        // ==================== THIẾT LẬP BẢNG ====================

        private void ConfigureGrid()
        {
            dgvProducts.Columns.Clear();

            AddColumn("MaSP", "Mã SP", 75);
            AddColumn("TenSP", "Tên sản phẩm", 160);
            AddColumn("LoaiSP", "Loại", 100);
            AddColumn("DonGia", "Đơn giá", 110);
            AddColumn("SoLuong", "Số lượng", 75);
            AddColumn("NgayNhap", "Ngày nhập", 100);

            DataGridViewCheckBoxColumn activeColumn =
                new DataGridViewCheckBoxColumn();

            activeColumn.Name = "ConKinhDoanh";
            activeColumn.DataPropertyName = "ConKinhDoanh";
            activeColumn.HeaderText = "Còn KD";
            activeColumn.FillWeight = 70;

            dgvProducts.Columns.Add(activeColumn);

            AddColumn("DuongDanAnh", "Đường dẫn ảnh", 140);

            dgvProducts.DefaultCellStyle.FormatProvider = vi;

            dgvProducts.Columns["DonGia"]
                .DefaultCellStyle.Format = "N2";

            dgvProducts.Columns["NgayNhap"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvProducts.EnableHeadersVisualStyles = false;

            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(22, 65, 82);

            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvProducts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dgvProducts.ColumnHeadersHeight = 42;
            dgvProducts.RowTemplate.Height = 34;

            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 247, 250);

            dgvProducts.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(15, 118, 110);

            dgvProducts.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvProducts.DataSource = productSource;
        }

        private void AddColumn(
            string propertyName, string title, int weight)
        {
            DataGridViewTextBoxColumn column =
                new DataGridViewTextBoxColumn();

            column.Name = propertyName;
            column.DataPropertyName = propertyName;
            column.HeaderText = title;
            column.FillWeight = weight;

            dgvProducts.Columns.Add(column);
        }

        // ==================== NỐI SỰ KIỆN ====================

        private void ConnectEvents()
        {
            Load += FrmProduct_Load;
            KeyDown += FrmProduct_KeyDown;

            miAdd.Click += delegate { AddProduct(); };
            miEdit.Click += delegate { EditProduct(); };
            miDelete.Click += delegate { DeleteProduct(); };
            miReset.Click += delegate { ResetAll(); };
            miExit.Click += delegate { Close(); };
            miGuide.Click += delegate { ShowHelp(); };

            tsAdd.Click += delegate { AddProduct(); };
            tsEdit.Click += delegate { EditProduct(); };
            tsDelete.Click += delegate { DeleteProduct(); };
            tsReset.Click += delegate { ResetAll(); };
            tsSearch.Click += delegate { SearchProducts(); };

            ctxEdit.Click += delegate { EditProduct(); };
            ctxDelete.Click += delegate { DeleteProduct(); };
            ctxDetails.Click += delegate { ShowDetails(); };

            btnChonAnh.Click += delegate { ChooseImage(); };

            txtTimKiem.KeyDown += delegate (
                object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchProducts();
                    e.SuppressKeyPress = true;
                }
            };

            dgvProducts.SelectionChanged += delegate
            {
                if (refreshingGrid)
                {
                    return;
                }

                Product product = GetSelectedProduct();
                selectedProduct = product;

                if (product != null)
                {
                    LoadProductToForm(product);
                }
            };

            dgvProducts.CellMouseDown += delegate (
                object sender, DataGridViewCellMouseEventArgs e)
            {
                if (e.Button != MouseButtons.Right)
                {
                    return;
                }

                dgvProducts.ClearSelection();
                selectedProduct = null;

                if (e.RowIndex >= 0)
                {
                    dgvProducts.CurrentCell =
                        dgvProducts.Rows[e.RowIndex].Cells[0];

                    dgvProducts.Rows[e.RowIndex].Selected = true;

                    LoadProductToForm(GetSelectedProduct());
                }
            };

            FormClosed += delegate { ClearImage(); };
        }

        // ==================== NẠP DỮ LIỆU ====================

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            cboLoaiSP.Items.Clear();

            cboLoaiSP.Items.AddRange(new object[]
            {
                "Điện tử",
                "Văn phòng",
                "Gia dụng",
                "Thời trang"
            });

            products.Clear();

            products.Add(new Product
            {
                MaSP = "SP01",
                TenSP = "Chuột không dây",
                LoaiSP = "Điện tử",
                DonGia = 150000m,
                SoLuong = 20,
                NgayNhap = DateTime.Today,
                ConKinhDoanh = true,
                DuongDanAnh = ""
            });

            products.Add(new Product
            {
                MaSP = "SP02",
                TenSP = "Sổ ghi chép",
                LoaiSP = "Văn phòng",
                DonGia = 25000m,
                SoLuong = 50,
                NgayNhap = DateTime.Today,
                ConKinhDoanh = true,
                DuongDanAnh = ""
            });

            products.Add(new Product
            {
                MaSP = "SP03",
                TenSP = "Bình giữ nhiệt",
                LoaiSP = "Gia dụng",
                DonGia = 180000m,
                SoLuong = 15,
                NgayNhap = DateTime.Today,
                ConKinhDoanh = true,
                DuongDanAnh = ""
            });

            RefreshGrid();
            ClearInput();
            UpdateStatus("Đã nạp 3 sản phẩm mẫu");
        }

        private Product GetSelectedProduct()
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                return null;
            }

            return dgvProducts.SelectedRows[0]
                .DataBoundItem as Product;
        }

        private void RefreshGrid()
        {
            refreshingGrid = true;

            try
            {
                var result = products.Where(p =>
                    string.IsNullOrEmpty(searchKeyword) ||
                    p.MaSP.IndexOf(
                        searchKeyword,
                        StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.TenSP.IndexOf(
                        searchKeyword,
                        StringComparison.OrdinalIgnoreCase) >= 0
                ).ToList();

                productSource.DataSource =
                    new BindingList<Product>(result);

                dgvProducts.ClearSelection();
                dgvProducts.CurrentCell = null;
                selectedProduct = null;
            }
            finally
            {
                refreshingGrid = false;
            }
        }

        private void UpdateStatus(string message)
        {
            decimal totalValue = products.Sum(
                p => p.DonGia * p.SoLuong);

            lblStatus.Text =
                message +
                "  |  Hiển thị: " + productSource.Count +
                "/" + products.Count + " sản phẩm" +
                "  |  Giá trị tồn kho: " +
                totalValue.ToString("N2", vi) + " VNĐ";
        }

        // ==================== KIỂM TRA DỮ LIỆU ====================

        private bool ValidateInput(bool editing)
        {
            errorProvider.Clear();

            bool valid = true;
            string code = txtMaSP.Text.Trim();

            if (string.IsNullOrWhiteSpace(code))
            {
                errorProvider.SetError(
                    txtMaSP, "Mã sản phẩm không được trống.");

                valid = false;
            }
            else
            {
                bool duplicated = products.Any(p =>
                    string.Equals(
                        p.MaSP,
                        code,
                        StringComparison.OrdinalIgnoreCase) &&
                    (!editing ||
                     !object.ReferenceEquals(p, selectedProduct)));

                if (duplicated)
                {
                    errorProvider.SetError(
                        txtMaSP, "Mã sản phẩm đã tồn tại.");

                    valid = false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                errorProvider.SetError(
                    txtTenSP, "Tên sản phẩm không được trống.");

                valid = false;
            }

            if (cboLoaiSP.SelectedIndex < 0)
            {
                errorProvider.SetError(
                    cboLoaiSP, "Vui lòng chọn loại sản phẩm.");

                valid = false;
            }

            if (numDonGia.Value <= 0)
            {
                errorProvider.SetError(
                    numDonGia, "Đơn giá phải lớn hơn 0.");

                valid = false;
            }

            if (numSoLuong.Value < 0)
            {
                errorProvider.SetError(
                    numSoLuong,
                    "Số lượng phải lớn hơn hoặc bằng 0.");

                valid = false;
            }

            if (dtpNgayNhap.Value.Date > DateTime.Today)
            {
                errorProvider.SetError(
                    dtpNgayNhap,
                    "Ngày nhập không được lớn hơn ngày hiện tại.");

                valid = false;
            }

            if (!valid)
            {
                UpdateStatus("Dữ liệu chưa hợp lệ");

                MessageBox.Show(
                    "Vui lòng kiểm tra các ô có biểu tượng lỗi.",
                    "Dữ liệu chưa hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            return valid;
        }

        // ==================== ĐỌC VÀ HIỂN THỊ DỮ LIỆU ====================

        private void CopyInputToProduct(Product product)
        {
            product.MaSP = txtMaSP.Text.Trim();
            product.TenSP = txtTenSP.Text.Trim();
            product.LoaiSP = cboLoaiSP.SelectedItem.ToString();
            product.DonGia = numDonGia.Value;
            product.SoLuong = (int)numSoLuong.Value;
            product.NgayNhap = dtpNgayNhap.Value.Date;
            product.ConKinhDoanh = chkConKinhDoanh.Checked;
            product.DuongDanAnh = imagePath;
        }

        private void LoadProductToForm(Product product)
        {
            if (product == null)
            {
                return;
            }

            selectedProduct = product;
            errorProvider.Clear();

            txtMaSP.Text = product.MaSP;
            txtTenSP.Text = product.TenSP;
            cboLoaiSP.SelectedItem = product.LoaiSP;
            numDonGia.Value = product.DonGia;
            numSoLuong.Value = product.SoLuong;
            dtpNgayNhap.Value = product.NgayNhap;
            chkConKinhDoanh.Checked = product.ConKinhDoanh;

            imagePath = product.DuongDanAnh ?? "";

            ClearImage();

            bool loaded = DisplayImage(imagePath);

            UpdateStatus(
                loaded
                ? "Đã chọn " + product.MaSP
                : "Đã chọn " + product.MaSP +
                  " - Không đọc được ảnh tại đường dẫn đã lưu");
        }

        private void ClearInput()
        {
            errorProvider.Clear();

            dgvProducts.ClearSelection();
            dgvProducts.CurrentCell = null;
            selectedProduct = null;

            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = -1;

            numDonGia.Value = 0;
            numSoLuong.Value = 0;

            dtpNgayNhap.Value = DateTime.Today;
            chkConKinhDoanh.Checked = true;

            imagePath = "";
            ClearImage();

            ActiveControl = txtMaSP;
            txtMaSP.Focus();
        }

        // ==================== THÊM ====================

        private void AddProduct()
        {
            if (!ValidateInput(false))
            {
                return;
            }

            Product product = new Product();
            CopyInputToProduct(product);

            products.Add(product);

            searchKeyword = "";
            txtTimKiem.Clear();

            RefreshGrid();
            ClearInput();

            UpdateStatus("Đã thêm sản phẩm " + product.MaSP);
        }

        // ==================== SỬA ====================

        private void EditProduct()
        {
            Product product = GetSelectedProduct();

            if (product == null)
            {
                UpdateStatus("Chưa chọn sản phẩm để sửa");

                MessageBox.Show(
                    "Vui lòng chọn một dòng trong bảng để sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            selectedProduct = product;

            if (!ValidateInput(true))
            {
                return;
            }

            CopyInputToProduct(product);

            RefreshGrid();
            ClearInput();

            UpdateStatus("Đã cập nhật sản phẩm " + product.MaSP);
        }

        // ==================== XÓA ====================

        private void DeleteProduct()
        {
            Product product = GetSelectedProduct();

            if (product == null)
            {
                UpdateStatus("Chưa chọn sản phẩm để xóa");

                MessageBox.Show(
                    "Vui lòng chọn một dòng trong bảng để xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DialogResult answer = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sản phẩm \"" +
                product.TenSP + "\" không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                UpdateStatus("Đã hủy thao tác xóa");
                return;
            }

            products.Remove(product);

            RefreshGrid();
            ClearInput();

            UpdateStatus("Đã xóa sản phẩm " + product.MaSP);
        }

        // ==================== TÌM KIẾM ====================

        private void SearchProducts()
        {
            searchKeyword = txtTimKiem.Text.Trim();

            RefreshGrid();
            ClearInput();

            UpdateStatus(
                string.IsNullOrEmpty(searchKeyword)
                ? "Đang hiển thị toàn bộ sản phẩm"
                : "Kết quả tìm kiếm: " + searchKeyword);
        }

        // ==================== LÀM MỚI ====================

        private void ResetAll()
        {
            searchKeyword = "";
            txtTimKiem.Clear();

            RefreshGrid();
            ClearInput();

            UpdateStatus("Đã làm mới");
        }

        // ==================== CHỌN ẢNH ====================

        private void ChooseImage()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Chọn ảnh sản phẩm";

                dialog.Filter =
                    "Ảnh sản phẩm|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                if (DisplayImage(dialog.FileName))
                {
                    imagePath = dialog.FileName;
                    UpdateStatus("Đã chọn ảnh sản phẩm");
                }
                else
                {
                    UpdateStatus("Không thể đọc file ảnh đã chọn");

                    MessageBox.Show(
                        "Không thể đọc ảnh. Vui lòng chọn ảnh hợp lệ.",
                        "Lỗi ảnh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private bool DisplayImage(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                ClearImage();
                return true;
            }

            Bitmap nextImage;

            try
            {
                using (Image original = Image.FromFile(path))
                {
                    nextImage = new Bitmap(original);
                }
            }
            catch
            {
                return false;
            }

            Image oldImage = picAnh.Image;
            picAnh.Image = nextImage;

            if (oldImage != null)
            {
                oldImage.Dispose();
            }

            return true;
        }

        private void ClearImage()
        {
            Image oldImage = picAnh.Image;
            picAnh.Image = null;

            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        }

        // ==================== XEM CHI TIẾT ====================

        private void ShowDetails()
        {
            Product product = GetSelectedProduct();

            if (product == null)
            {
                UpdateStatus("Chưa chọn sản phẩm");

                MessageBox.Show(
                    "Vui lòng chọn một sản phẩm để xem chi tiết.");

                return;
            }

            string state = product.ConKinhDoanh
                ? "Còn kinh doanh"
                : "Ngừng kinh doanh";

            string details =
                "Mã sản phẩm: " + product.MaSP +
                "\nTên sản phẩm: " + product.TenSP +
                "\nLoại: " + product.LoaiSP +
                "\nĐơn giá: " +
                    product.DonGia.ToString("N2", vi) + " VNĐ" +
                "\nSố lượng: " + product.SoLuong +
                "\nNgày nhập: " +
                    product.NgayNhap.ToString("dd/MM/yyyy") +
                "\nTrạng thái: " + state +
                "\nĐường dẫn ảnh: " + product.DuongDanAnh;

            MessageBox.Show(
                details,
                "Chi tiết sản phẩm",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateStatus("Đã xem chi tiết " + product.MaSP);
        }

        // ==================== TRỢ GIÚP ====================

        private void ShowHelp()
        {
            MessageBox.Show(
                "HƯỚNG DẪN SỬ DỤNG\n\n" +
                "1. Nhập thông tin rồi nhấn Thêm.\n" +
                "2. Chọn dòng, đổi thông tin rồi nhấn Sửa.\n" +
                "3. Chọn dòng rồi nhấn Xóa.\n" +
                "4. Tìm kiếm theo mã hoặc tên sản phẩm.\n" +
                "5. Nhấn Làm mới để xóa ô nhập và bỏ tìm kiếm.\n" +
                "6. Nhấp phải dòng để mở menu thao tác.\n\n" +
                "PHÍM TẮT\n" +
                "Ctrl + N: Làm mới.\n" +
                "Ctrl + S: Sửa sản phẩm đang chọn.\n" +
                "Ctrl + F: Chuyển đến ô tìm kiếm.\n" +
                "Delete khi bảng có tiêu điểm: Xóa sản phẩm.\n\n" +
                "Dữ liệu chỉ lưu trong bộ nhớ.",
                "Trợ giúp",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateStatus("Đã xem hướng dẫn");
        }

        // ==================== PHÍM TẮT ====================

        private void FrmProduct_KeyDown(
            object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                ResetAll();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                EditProduct();
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                txtTimKiem.Focus();
            }
            else if (e.KeyCode == Keys.Delete &&
                     dgvProducts.ContainsFocus)
            {
                DeleteProduct();
            }
            else
            {
                return;
            }

            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }
}