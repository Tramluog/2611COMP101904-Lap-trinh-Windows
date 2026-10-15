using System;
using System.Windows.Forms;
using ShopManagerMini.Forms;
using ShopManagerMini.Models;

namespace ShopManagerMini
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                User currentUser;

                using (FrmLogin login = new FrmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        break;
                    }

                    currentUser = login.LoggedInUser;
                }

                using (FrmMain main = new FrmMain(currentUser))
                {
                    Application.Run(main);

                    if (!main.LogoutRequested)
                    {
                        break;
                    }
                }
            }
        }
    }
}