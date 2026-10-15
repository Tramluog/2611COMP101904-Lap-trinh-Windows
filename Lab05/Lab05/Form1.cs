using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lab05
{
    public partial class frmDangKy : Form
    {
        private readonly string[] tenKhoaHoc =
        {
            "C# WinForms cơ bản",
            "SQL Server cơ bản",
            "Web Frontend cơ bản",
            "Lập trình Python cơ bản"
        };

        private readonly decimal[] hocPhiMoiThang =
        {
            800000m,
            700000m,
            750000m,
            650000m
        };

        private readonly CultureInfo vanHoaVN =
            CultureInfo.GetCultureInfo("vi-VN");

        public frmDangKy()
        {
            InitializeComponent();

            // Gắn các sự kiện cho Form và control.
            this.Load += Form1_Load;

            cboKhoaHoc.SelectedIndexChanged +=
                cboKhoaHoc_SelectedIndexChanged;

            numSoThang.ValueChanged +=
                numSoThang_ValueChanged;

            btnDangKy.Click += btnDangKy_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnThoat.Click += btnThoat_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoaHoc.Items.Clear();
            cboKhoaHoc.Items.AddRange(tenKhoaHoc);

            numSoThang.Minimum = 1;
            numSoThang.Maximum = 12;

            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            LamMoiDuLieu();
        }

        private decimal TinhTongHocPhi()
        {
            int viTri = cboKhoaHoc.SelectedIndex;

            if (viTri < 0 || viTri >= hocPhiMoiThang.Length)
            {
                return 0m;
            }

            return hocPhiMoiThang[viTri] * numSoThang.Value;
        }

        private void CapNhatTongTien()
        {
            lblTongTien.Text =
                TinhTongHocPhi().ToString("N0", vanHoaVN) + " VNĐ";
        }

        private void cboKhoaHoc_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void numSoThang_ValueChanged(
            object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên học viên.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập số điện thoại.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSoDienThoai.Focus();
                return;
            }

            if (cboKhoaHoc.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn khóa học.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboKhoaHoc.Focus();
                return;
            }

            string hinhThuc =
                radOnline.Checked ? "Online" : "Trực tiếp";

            string nhanEmail =
                chkNhanEmail.Checked ? "Có" : "Không";

            string thongTin =
                "PHIẾU ĐĂNG KÝ KHÓA HỌC\n\n" +
                "Họ tên: " + txtHoTen.Text.Trim() + "\n" +
                "Số điện thoại: " +
                    txtSoDienThoai.Text.Trim() + "\n" +
                "Ngày sinh: " +
                    dtpNgaySinh.Value.ToString("dd/MM/yyyy") + "\n" +
                "Khóa học: " +
                    cboKhoaHoc.SelectedItem.ToString() + "\n" +
                "Hình thức học: " + hinhThuc + "\n" +
                "Số tháng: " +
                    numSoThang.Value.ToString("0") + "\n" +
                "Tổng học phí: " +
                    TinhTongHocPhi().ToString("N0", vanHoaVN) +
                    " VNĐ\n" +
                "Nhận email thông báo: " + nhanEmail;

            MessageBox.Show(
                thongTin,
                "Đăng ký thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void LamMoiDuLieu()
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();

            dtpNgaySinh.Value = DateTime.Today;
            chkNhanEmail.Checked = false;

            if (cboKhoaHoc.Items.Count > 0)
            {
                cboKhoaHoc.SelectedIndex = 0;
            }

            radOnline.Checked = true;
            numSoThang.Value = 1;

            CapNhatTongTien();

            ActiveControl = txtHoTen;
            txtHoTen.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiDuLieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {

        }
    }
}