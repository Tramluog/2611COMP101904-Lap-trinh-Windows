using System;
using System.Windows.Forms;
using ShopManagerMini.Models;

namespace ShopManagerMini.Forms
{
    public partial class FrmLogin : Form
    {
        public User LoggedInUser { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();

            AcceptButton = btnLogin;
            CancelButton = btnExit;

            btnLogin.Click += BtnLogin_Click;

            btnExit.Click += delegate
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            Shown += delegate { txtUsername.Focus(); };
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (username == "admin" && password == "123")
            {
                LoggedInUser = new User
                {
                    Username = "admin",
                    FullName = "Quản trị viên",
                    Role = "Admin"
                };
            }
            else if (username == "user" && password == "123")
            {
                LoggedInUser = new User
                {
                    Username = "user",
                    FullName = "Nhân viên bán hàng",
                    Role = "User"
                };
            }
            else
            {
                MessageBox.Show(
                    "Tên đăng nhập hoặc mật khẩu không đúng.",
                    "Đăng nhập thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}