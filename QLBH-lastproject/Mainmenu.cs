using QLBH_lastproject.UC_Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace QLBH_lastproject
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void giohang_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            cart.BringToFront();
            this.Hide();
        }

        private void trangchu_Click(object sender, EventArgs e)
        {
            FUserInfor fUserInfor = new FUserInfor();
            this.Hide();
            fUserInfor.ShowDialog();
        }

        private void huy_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Bạn muốn thoát ?", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                dialogResult = DialogResult.Cancel;

            }
        }

        private void donhang_Click(object sender, EventArgs e)
        {
            Dathang order = new Dathang();
            this.Controls.Add(order);
            order.BringToFront();
        }

        private void taikhoan_Click(object sender, EventArgs e)
        {
            frmAdPage account = new frmAdPage();
            account.Show();
            account.BringToFront();
            this.Hide();
        }
    }
}
