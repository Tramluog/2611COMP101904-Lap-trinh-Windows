namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtKetQua.Multiline = true;
            txtKetQua.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblKhoa_Click(object sender, EventArgs e)
        {

        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoa.Items.Add("Công nghệ thông tin");
            cboKhoa.Items.Add("Toán");
            cboKhoa.Items.Add("Vật lý");
            cboKhoa.Items.Add("Tâm lý học");
            cboKhoa.Items.Add("Ngôn ngữ Anh");
            cboKhoa.Items.Add("Vật lý");

            cboKhoa.SelectedIndex = 0;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoTen.Focus();
                return;
            }

            if (txtNamSinh.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập năm sinh!");
                txtNamSinh.Focus();
                return;
            }

            int namSinh;

            if (!int.TryParse(txtNamSinh.Text, out namSinh))
            {
                MessageBox.Show("Năm sinh phải là số nguyên!");
                txtNamSinh.Focus();
                return;
            }

            int namHienTai = DateTime.Now.Year;

            if (namSinh < 1900 || namSinh > namHienTai)
            {
                MessageBox.Show("Năm sinh phải từ 1900 đến " + namHienTai + "!");
                txtNamSinh.Focus();
                return;
            }

            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email!");
                txtEmail.Focus();
                return;
            }

            if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            if (cboKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khoa/lớp!");
                return;
            }

            string gioiTinh;

            if (radNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }

            int tuoi = namHienTai - namSinh;

            txtKetQua.Text =
                "THÔNG TIN SINH VIÊN\r\n" +
                "Họ tên: " + txtHoTen.Text + "\r\n" +
                "Tuổi: " + tuoi + "\r\n" +
                "Email: " + txtEmail.Text + "\r\n" +
                "Giới tính: " + gioiTinh + "\r\n" +
                "Khoa/Lớp: " + cboKhoa.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtEmail.Clear();
            txtKetQua.Clear();

            radNam.Checked = false;
            radNu.Checked = false;

            cboKhoa.SelectedIndex = -1;

            txtHoTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show(
       "Bạn có chắc chắn muốn thoát chương trình không?",
       "Xác nhận thoát",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (ketQua == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
