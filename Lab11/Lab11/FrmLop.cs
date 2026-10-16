using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Lab11_ClassManager
{
    public partial class FrmLop : Form
    {
        private readonly LopRepository repository =
            new LopRepository();

        private string selectedMaLop;
        private bool loadingGrid;

        public FrmLop()
        {
            InitializeComponent();

            ConfigureGrid();
            ConnectEvents();
        }

        // ==================== THIET LAP BANG ====================

        private void ConfigureGrid()
        {
            dgvLop.AutoGenerateColumns = false;
            dgvLop.Columns.Clear();

            dgvLop.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "MaLop",
                    DataPropertyName = "MaLop",
                    HeaderText = "Mã lớp",
                    FillWeight = 80
                });

            dgvLop.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "TenLop",
                    DataPropertyName = "TenLop",
                    HeaderText = "Tên lớp",
                    FillWeight = 180
                });

            dgvLop.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "MaKhoa",
                    DataPropertyName = "MaKhoa",
                    HeaderText = "Mã khoa",
                    Visible = false
                });

            dgvLop.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "TenKhoa",
                    DataPropertyName = "TenKhoa",
                    HeaderText = "Khoa",
                    FillWeight = 140
                });
        }

        // ==================== KET NOI SU KIEN ====================

        private void ConnectEvents()
        {
            Load += delegate
            {
                RunDatabaseAction(delegate
                {
                    LoadKhoa();
                    LoadLop();
                });
            };

            btnThem.Click += delegate
            {
                RunDatabaseAction(AddLop);
            };

            btnSua.Click += delegate
            {
                RunDatabaseAction(EditLop);
            };

            btnXoa.Click += delegate
            {
                RunDatabaseAction(DeleteLop);
            };

            btnLamMoi.Click += delegate
            {
                RunDatabaseAction(delegate
                {
                    txtTimKiem.Clear();

                    LoadKhoa();
                    LoadLop();
                });
            };

            btnTimKiem.Click += delegate
            {
                RunDatabaseAction(LoadLop);
            };

            txtTimKiem.KeyDown += delegate (
                object sender,
                KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnTimKiem.PerformClick();
                    e.SuppressKeyPress = true;
                }
            };

            dgvLop.SelectionChanged +=
                DgvLop_SelectionChanged;
        }

        // ==================== NAP KHOA ====================

        private void LoadKhoa()
        {
            DataTable table = repository.GetKhoa();

            cboKhoa.DataSource = null;
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
            cboKhoa.DataSource = table;

            cboKhoa.SelectedIndex = -1;
        }

        // ==================== NAP VA TIM KIEM LOP ====================

        private void LoadLop()
        {
            DataTable table =
                repository.GetLop(
                    txtTimKiem.Text.Trim());

            loadingGrid = true;

            try
            {
                dgvLop.DataSource = table;
                dgvLop.ClearSelection();
                dgvLop.CurrentCell = null;

                ClearInput();

                lblTrangThai.Text =
                    "Đã tải từ SQL Server: " +
                    table.Rows.Count + " lớp.";
            }
            finally
            {
                loadingGrid = false;
            }
        }

        // ==================== CHON DONG ====================

        private void DgvLop_SelectionChanged(
            object sender,
            EventArgs e)
        {
            if (loadingGrid ||
                dgvLop.SelectedRows.Count == 0)
            {
                return;
            }

            DataRowView row =
                dgvLop.SelectedRows[0].DataBoundItem
                as DataRowView;

            if (row == null)
            {
                return;
            }

            selectedMaLop = row["MaLop"].ToString();

            txtMaLop.Text = selectedMaLop;
            txtTenLop.Text = row["TenLop"].ToString();

            cboKhoa.SelectedValue =
                row["MaKhoa"].ToString();

            // Khi chon dong, chi cho sua ten lop.
            txtMaLop.ReadOnly = true;
            cboKhoa.Enabled = false;

            lblTrangThai.Text =
                "Đang chọn lớp: " + selectedMaLop;
        }

        // ==================== XOA NOI DUNG NHAP ====================

        private void ClearInput()
        {
            selectedMaLop = null;

            txtMaLop.ReadOnly = false;
            cboKhoa.Enabled = true;

            txtMaLop.Clear();
            txtTenLop.Clear();

            cboKhoa.SelectedIndex = -1;

            ActiveControl = txtMaLop;
        }

        // ==================== KIEM TRA DU LIEU ====================

        private bool ValidateInput(bool adding)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show(
                    "Mã lớp không được để trống.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMaLop.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenLop.Text))
            {
                MessageBox.Show(
                    "Tên lớp không được để trống.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTenLop.Focus();
                return false;
            }

            if (adding && cboKhoa.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn khoa của lớp.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cboKhoa.Focus();
                return false;
            }

            return true;
        }

        // ==================== THEM LOP ====================

        private void AddLop()
        {
            if (!ValidateInput(true))
            {
                return;
            }

            string maLop = txtMaLop.Text.Trim();
            string tenLop = txtTenLop.Text.Trim();
            string maKhoa =
                cboKhoa.SelectedValue.ToString();

            if (repository.Exists(maLop))
            {
                MessageBox.Show(
                    "Mã lớp đã tồn tại. Không thể thêm trùng.",
                    "Trùng mã lớp",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            repository.Insert(
                maLop,
                tenLop,
                maKhoa);

            txtTimKiem.Clear();
            LoadLop();

            MessageBox.Show(
                "Đã thêm lớp thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==================== SUA TEN LOP ====================

        private void EditLop()
        {
            if (string.IsNullOrEmpty(selectedMaLop))
            {
                MessageBox.Show(
                    "Vui lòng chọn một dòng trong bảng để sửa.",
                    "Chưa chọn lớp",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateInput(false))
            {
                return;
            }

            int affected = repository.Update(
                selectedMaLop,
                txtTenLop.Text.Trim());

            txtTimKiem.Clear();
            LoadLop();

            MessageBox.Show(
                affected > 0
                    ? "Đã cập nhật tên lớp."
                    : "Lớp không còn tồn tại. " +
                      "Danh sách đã được tải lại.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==================== XOA LOP ====================

        private void DeleteLop()
        {
            if (string.IsNullOrEmpty(selectedMaLop))
            {
                MessageBox.Show(
                    "Vui lòng chọn một dòng trong bảng để xóa.",
                    "Chưa chọn lớp",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string maLop = selectedMaLop;

            DialogResult answer = MessageBox.Show(
                "Bạn có muốn xóa lớp " + maLop + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            if (repository.HasStudents(maLop))
            {
                MessageBox.Show(
                    "Không thể xóa lớp đang có sinh viên.",
                    "Không thể xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int affected = repository.Delete(maLop);

            txtTimKiem.Clear();
            LoadLop();

            MessageBox.Show(
                affected > 0
                    ? "Đã xóa lớp."
                    : "Lớp không còn tồn tại. " +
                      "Danh sách đã được tải lại.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ==================== XU LY LOI ====================

        private void RunDatabaseAction(Action action)
        {
            try
            {
                action();
            }
            catch (SqlException ex)
            {
                string message;

                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    message =
                        "Mã lớp đã tồn tại. " +
                        "Không thể thêm trùng.";
                }
                else if (ex.Number == 547)
                {
                    message =
                        "Thao tác bị chặn bởi khóa ngoại.\n" +
                        "Kiểm tra khoa đã chọn hoặc " +
                        "sinh viên thuộc lớp.";
                }
                else
                {
                    message =
                        "Không thể thực hiện thao tác SQL Server.\n" +
                        ex.Message;
                }

                lblTrangThai.Text =
                    "Thao tác chưa thành công.";

                MessageBox.Show(
                    message,
                    "Lỗi cơ sở dữ liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                lblTrangThai.Text =
                    "Thao tác chưa thành công.";

                MessageBox.Show(
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}