namespace ShopManagerMini.Forms
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();

            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();

            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.slUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.slRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.slClock = new System.Windows.Forms.ToolStripStatusLabel();

            this.tmrClock =
                new System.Windows.Forms.Timer(this.components);

            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();

            // menuMain
            this.menuMain.Name = "menuMain";
            this.menuMain.BackColor = System.Drawing.Color.White;
            this.menuMain.Font =
                new System.Drawing.Font("Segoe UI", 11F);
            this.menuMain.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.mnuSystem,
                    this.mnuCatalog,
                    this.mnuHelp
                });

            // Hệ thống
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Text = "Hệ thống";
            this.mnuSystem.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.mnuLogout,
                    this.mnuExit
                });

            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Text = "Đăng xuất";

            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Text = "Thoát";

            // Danh mục
            this.mnuCatalog.Name = "mnuCatalog";
            this.mnuCatalog.Text = "Danh mục";
            this.mnuCatalog.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.mnuProduct,
                    this.mnuCustomer
                });

            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.Text = "Quản lý sản phẩm";

            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Text = "Quản lý khách hàng";

            // Trợ giúp
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Text = "Trợ giúp";
            this.mnuHelp.DropDownItems.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.mnuAbout
                });

            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Text = "Giới thiệu";

            // Thanh trạng thái
            this.statusMain.Name = "statusMain";
            this.statusMain.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[]
                {
                    this.slUser,
                    this.slRole,
                    this.slClock
                });

            this.slUser.Name = "slUser";
            this.slUser.Text = "Người dùng:";

            this.slRole.Name = "slRole";
            this.slRole.Text = "Vai trò:";

            this.slClock.Name = "slClock";
            this.slClock.Text = "Thời gian:";
            this.slClock.Spring = true;
            this.slClock.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;

            // Timer
            this.tmrClock.Interval = 1000;

            // FrmMain
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;
            this.Name = "FrmMain";
            this.Text = "ShopManagerMini - Quản lý cửa hàng mini";

            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.menuMain);

            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalog;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;

        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel slUser;
        private System.Windows.Forms.ToolStripStatusLabel slRole;
        private System.Windows.Forms.ToolStripStatusLabel slClock;
        private System.Windows.Forms.Timer tmrClock;
    }
}