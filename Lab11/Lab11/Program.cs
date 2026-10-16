using System;
using System.Windows.Forms;

namespace Lab11_ClassManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmLop());
        }
    }
}