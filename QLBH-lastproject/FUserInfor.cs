using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_lastproject
{
    public partial class FUserInfor : Form
    {
        public FUserInfor()
        {
            InitializeComponent();
        }

        private void FUserInfor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Mainmenu().Visible = true;
        }
    }
}
