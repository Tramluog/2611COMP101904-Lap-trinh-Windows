using System.Windows.Forms;

namespace ShopManagerMini.Forms
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();

            btnClose.Click += delegate { Close(); };
        }
    }
}