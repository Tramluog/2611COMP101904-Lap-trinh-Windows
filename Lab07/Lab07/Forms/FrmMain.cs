using System;
using System.Linq;
using System.Windows.Forms;
using ShopManagerMini.Models;

namespace ShopManagerMini.Forms
{
    public partial class FrmMain : Form
    {
        public bool LogoutRequested { get; private set; }

        public FrmMain()
        {
            InitializeComponent();

            mnuProduct.Click += delegate
            {
                OpenChild(() => new FrmProduct());
            };

            mnuCustomer.Click += delegate
            {
                OpenChild(() => new FrmCustomer());
            };

            mnuAbout.Click += delegate
            {
                OpenChild(() => new FrmAbout());
            };

            mnuLogout.Click += delegate
            {
                DialogResult answer = MessageBox.Show(
                    "Bạn có muốn đăng xuất không?",
                    "Xác nhận đăng xuất",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    LogoutRequested = true;
                    Close();
                }
            };

            mnuExit.Click += delegate { Close(); };

            tmrClock.Tick += delegate { UpdateClock(); };

            Load += delegate
            {
                UpdateClock();
                tmrClock.Start();
            };

            FormClosing += FrmMain_FormClosing;
            FormClosed += delegate { tmrClock.Stop(); };
        }

        public FrmMain(User user) : this()
        {
            slUser.Text = "Người dùng: " + user.FullName;
            slRole.Text = "  |  Vai trò: " + user.Role;
        }

        private void UpdateClock()
        {
            slClock.Text =
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void OpenChild<T>(Func<T> createForm)
            where T : Form
        {
            T existing = MdiChildren.OfType<T>().FirstOrDefault();

            if (existing != null)
            {
                if (existing.WindowState == FormWindowState.Minimized)
                {
                    existing.WindowState = FormWindowState.Normal;
                }

                existing.Activate();
                return;
            }

            T child = createForm();
            child.MdiParent = this;
            child.Show();
        }

        private void FrmMain_FormClosing(
            object sender, FormClosingEventArgs e)
        {
            if (LogoutRequested)
            {
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}