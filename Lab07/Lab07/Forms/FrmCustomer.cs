using System;
using System.Linq;
using System.Windows.Forms;
using ShopManagerMini.Models;

namespace ShopManagerMini.Forms
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();

            btnAdd.Click += delegate { AddCustomer(); };
            btnReset.Click += delegate { ClearInput(); };

            Load += delegate
            {
                cboLoaiKH.Items.Clear();

                cboLoaiKH.Items.AddRange(new object[]
                {
                    "Thường", "Thành viên", "VIP"
                });

                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.Columns.Clear();

                AddColumn("MaKH", "Mã khách hàng");
                AddColumn("HoTen", "Họ tên");
                AddColumn("SoDienThoai", "Số điện thoại");
                AddColumn("LoaiKH", "Loại khách hàng");

                dgvCustomers.DataSource = StoreData.Customers;

                UpdateCount();
                ClearInput();
            };
        }

        private void AddColumn(string property, string title)
        {
            dgvCustomers.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = property,
                    HeaderText = title
                });
        }

        private void AddCustomer()
        {
            string code = txtMaKH.Text.Trim();
            string name = txtHoTen.Text.Trim();
            string phone = txtSoDienThoai.Text.Trim();

            if (string.IsNullOrWhiteSpace(code) ||
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(phone) ||
                cboLoaiKH.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin khách hàng.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool duplicated = StoreData.Customers.Any(c =>
                string.Equals(
                    c.MaKH,
                    code,
                    StringComparison.OrdinalIgnoreCase));

            if (duplicated)
            {
                MessageBox.Show(
                    "Mã khách hàng đã tồn tại.",
                    "Mã trùng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            StoreData.Customers.Add(new Customer
            {
                MaKH = code,
                HoTen = name,
                SoDienThoai = phone,
                LoaiKH = cboLoaiKH.SelectedItem.ToString()
            });

            UpdateCount();
            ClearInput();
        }

        private void UpdateCount()
        {
            lblCount.Text =
                "Tổng số khách hàng: " + StoreData.Customers.Count;
        }

        private void ClearInput()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            cboLoaiKH.SelectedIndex = -1;

            dgvCustomers.ClearSelection();

            ActiveControl = txtMaKH;
        }
    }
}