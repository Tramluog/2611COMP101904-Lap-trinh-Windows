using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ShopManagerMini.Models;

namespace ShopManagerMini.Forms
{
    public partial class FrmProduct : Form
    {
        private bool refreshing;
        private string keyword = "";

        public FrmProduct()
        {
            InitializeComponent();

            btnAdd.Click += delegate { AddProduct(); };
            btnEdit.Click += delegate { EditProduct(); };
            btnDelete.Click += delegate { DeleteProduct(); };

            btnReset.Click += delegate
            {
                keyword = "";
                txtSearch.Clear();
                RefreshGrid();
                ClearInput();
            };

            btnSearch.Click += delegate
            {
                keyword = txtSearch.Text.Trim();
                RefreshGrid();
                ClearInput();
            };

            txtSearch.KeyDown += delegate (
                object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch.PerformClick();
                    e.SuppressKeyPress = true;
                }
            };

            dgvProducts.SelectionChanged += delegate
            {
                if (refreshing)
                {
                    return;
                }

                Product product = GetSelectedProduct();

                if (product != null)
                {
                    LoadProductToForm(product);
                }
            };

            Load += delegate
            {
                cboLoaiSP.Items.Clear();

                cboLoaiSP.Items.AddRange(new object[]
                {
                    "Điện tử",
                    "Văn phòng",
                    "Gia dụng",
                    "Thời trang"
                });

                ConfigureGrid();
                RefreshGrid();
                ClearInput();
            };
        }

        private void ConfigureGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();

            AddColumn("MaSP", "Mã sản phẩm");
            AddColumn("TenSP", "Tên sản phẩm");
            AddColumn("LoaiSP", "Loại sản phẩm");
            AddColumn("DonGia", "Đơn giá");
            AddColumn("SoLuong", "Số lượng");

            dgvProducts.Columns["DonGia"]
                .DefaultCellStyle.Format = "N2";

            dgvProducts.Columns["DonGia"]
                .DefaultCellStyle.FormatProvider =
                    CultureInfo.GetCultureInfo("vi-VN");
        }

        private void AddColumn(string property, string title)
        {
            dgvProducts.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = property,
                    DataPropertyName = property,
                    HeaderText = title
                });
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
            refreshing = true;

            try
            {
                var result = StoreData.Products.Where(p =>
                    string.IsNullOrEmpty(keyword) ||
                    p.MaSP.IndexOf(
                        keyword,
                        StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.TenSP.IndexOf(
                        keyword,
                        StringComparison.OrdinalIgnoreCase) >= 0
                ).ToList();

                dgvProducts.DataSource =
                    new BindingList<Product>(result);

                dgvProducts.ClearSelection();
                dgvProducts.CurrentCell = null;

                lblCount.Text =
                    "Hiển thị: " + result.Count +
                    "/" + StoreData.Products.Count + " sản phẩm";
            }
            finally
            {
                refreshing = false;
            }
        }

        private void LoadProductToForm(Product product)
        {
            txtMaSP.Text = product.MaSP;
            txtTenSP.Text = product.TenSP;
            cboLoaiSP.SelectedItem = product.LoaiSP;
            numDonGia.Value = product.DonGia;
            numSoLuong.Value = product.SoLuong;
        }

        private void ClearInput()
        {
            dgvProducts.ClearSelection();
            dgvProducts.CurrentCell = null;

            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = -1;
            numDonGia.Value = 0;
            numSoLuong.Value = 0;

            ActiveControl = txtMaSP;
        }

        private bool ValidateInput(Product original)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) ||
                string.IsNullOrWhiteSpace(txtTenSP.Text) ||
                cboLoaiSP.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập mã, tên và chọn loại sản phẩm.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            bool duplicated = StoreData.Products.Any(p =>
                string.Equals(
                    p.MaSP,
                    txtMaSP.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase) &&
                !object.ReferenceEquals(p, original));

            if (duplicated)
            {
                MessageBox.Show(
                    "Mã sản phẩm đã tồn tại.",
                    "Mã trùng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (numDonGia.Value < 0 || numSoLuong.Value < 0)
            {
                MessageBox.Show(
                    "Đơn giá và số lượng không được âm.");

                return false;
            }

            return true;
        }

        private void CopyInput(Product product)
        {
            product.MaSP = txtMaSP.Text.Trim();
            product.TenSP = txtTenSP.Text.Trim();
            product.LoaiSP = cboLoaiSP.SelectedItem.ToString();
            product.DonGia = numDonGia.Value;
            product.SoLuong = (int)numSoLuong.Value;
        }

        private void AddProduct()
        {
            if (!ValidateInput(null))
            {
                return;
            }

            Product product = new Product();
            CopyInput(product);

            StoreData.Products.Add(product);

            keyword = "";
            txtSearch.Clear();

            RefreshGrid();
            ClearInput();
        }

        private void EditProduct()
        {
            Product product = GetSelectedProduct();

            if (product == null)
            {
                MessageBox.Show(
                    "Hãy chọn một dòng trong bảng để sửa.");

                return;
            }

            if (!ValidateInput(product))
            {
                return;
            }

            CopyInput(product);

            RefreshGrid();
            ClearInput();
        }

        private void DeleteProduct()
        {
            Product product = GetSelectedProduct();

            if (product == null)
            {
                MessageBox.Show(
                    "Hãy chọn một dòng trong bảng để xóa.");

                return;
            }

            DialogResult answer = MessageBox.Show(
                "Bạn có muốn xóa sản phẩm \"" +
                product.TenSP + "\" không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            StoreData.Products.Remove(product);

            RefreshGrid();
            ClearInput();
        }
    }
}