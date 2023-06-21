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
            for (int i = 0; i < 10; i++)
            {
                ceat_cartprs();

            }
        }
        private void ceat_cartprs()
        {
            Panel penl = new Panel();
            //penl.Size = new Size(153, 210);
            penl.BackColor = SystemColors.Control;
            penl.SetBounds(10, 5, 155, 210);

            PictureBox pictureBox = new PictureBox();
            // pictureBox.Size = new Size(140, 140);
            Image myimage = new Bitmap(@"C:\Users\ASUS\Pictures\langbac.jpg");
            pictureBox.Click += Item_Click;
            pictureBox.BackgroundImage = myimage;
            pictureBox.SetBounds(5, 4, 140, 140);

            Label namePrs = new Label();
            namePrs.Text = "Iphone 14 Pro Max";
            namePrs.SetBounds(7, 151, 140, 15);
            namePrs.Click += Item_Click;
            Label pricePrs = new Label();
            pricePrs.Text = "21.000.000";
            pricePrs.SetBounds(7, 184, 140, 15);
            pricePrs.Click += Item_Click;

            Button btn_Add = new Button();
            btn_Add.Text = "Add";
            btn_Add.SetBounds(106, 169, 40, 40);
            btn_Add.Click += Item_Click;

            penl.Click += Item_Click;

            penl.Controls.Add(btn_Add);
            penl.Controls.Add(pictureBox);
            penl.Controls.Add(namePrs);
            penl.Controls.Add(pricePrs);

            flowLayoutPanel1.Controls.Add(penl);

        }

        private void Item_Click(object sender, EventArgs e)
        {
            /* InfoPros ifo = new InfoPros();
             //flowLayoutPanel1.Controls.Clear();
             this.Controls.Add(ifo);
             ifo.BringToFront();*/
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
