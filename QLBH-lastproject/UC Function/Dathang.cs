using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_lastproject.UC_Function
{
    public partial class Dathang : UserControl
    {
        public Dathang()
        {
            InitializeComponent();
        }

        private void Dathang_Load(object sender, EventArgs e)
        {

        }

        private void trolai_Click(object sender, EventArgs e)
        {
            Mainmenu mainmenu = this.Parent as Mainmenu;
            this.Dispose();
            mainmenu.Show();
        }
    }
}
