using Microsoft.VisualBasic.Devices;
using QLBH_lastproject.ConnectSql;
using QLBH_lastproject.UC_Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLBH_lastproject
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
            //SqlData bd = new SqlData();
            Load_Data();
        }
        public Mainmenu(int i)
        {
            InitializeComponent();
            //SqlData bd = new SqlData();

            if(i == 2)
            {
                btnAdmin.Visible = false;
                button5.SetBounds(0, 310, 197, 61);
            }

            Load_Data();
        }
        private void Load_Data()
        {
            DataTable dt = new SqlData().Seclection();
            foreach (DataRow row in dt.Rows)
            {
                ceat_cartprs(row["productName"].ToString(), row["price"].ToString(), row["productID"].ToString());
            }
        }
        private void ceat_cartprs(string name, string price, string id)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = Path.Combine("..", "img", id + ".bmp");
            string fullPath = @"D:\CS project\QLBH-lastproject\QLBH-lastproject\img\" + id + ".bmp";

            Panel penl = new Panel();
            //penl.Size = new Size(153, 210);
            //penl.BackColor = SystemColors.Control;
            penl.BackColor = SystemColors.ButtonShadow;
            penl.Margin = new Padding(10);
            penl.SetBounds(10, 5, 155, 210);
            penl.Name = id;

            PictureBox pictureBox = new PictureBox();
            // pictureBox.Size = new Size(140, 140);
            //Image myimage = new Bitmap("img\iphne.jpg");

            //pictureBox.Image = Image.FromFile();
            pictureBox.Click += Item_Click;
            //pictureBox.BackgroundImage = myimage;
            pictureBox.Padding = new Padding(5);
            pictureBox.SetBounds(5, 4, 140, 140);
            FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read);

            pictureBox.Image = Image.FromStream(fs);

            fs.Close();
            pictureBox.Name = id;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            Label namePrs = new Label();
            namePrs.Text = name;
            namePrs.SetBounds(7, 151, 140, 15);
            namePrs.Name = id;
            namePrs.Click += ItemName_Click;
            Label pricePrs = new Label();
            string a = string.Format("{0:0,0}", int.Parse(price));
            pricePrs.Text = a + " VND";
            pricePrs.SetBounds(7, 184, 140, 15);
            pricePrs.Name = id;
            pricePrs.Click += ItemPrice_Click;

            //System.Windows.Forms.Button btn_Add = new System.Windows.Forms.Button();
            Button btn_Add = new Button();
            btn_Add.Text = "Add";
            btn_Add.SetBounds(106, 169, 40, 40);
            btn_Add.Name = id;
            btn_Add.TabIndex = int.Parse(price);
            btn_Add.Click += Item_Clicks;

            penl.Click += ItemCart_Click;

            penl.Controls.Add(btn_Add);
            penl.Controls.Add(pictureBox);
            penl.Controls.Add(namePrs);
            penl.Controls.Add(pricePrs);

            flowLayoutPanel1.Controls.Add(penl);

        }
        private void ShowInfproduct(string n)
        {
            InfoProduct ifo = new InfoProduct(int.Parse(n), "info");
            ////flowLayoutPanel1.Controls.Clear();
            ifo.Show();
            ifo.BringToFront();
        }
        private void Item_Click(object sender, EventArgs e)
        {

            //int n = int.Parse(flowLayoutPanel1.Controls[0].Name);
            PictureBox clickPanel = (PictureBox)sender;
            string a = clickPanel.Name;
            ShowInfproduct(a);

        }
        private void ItemName_Click(object sender, EventArgs e)
        {

            //int n = int.Parse(flowLayoutPanel1.Controls[0].Name);
            Label clickPanel = (Label)sender;
            string a = clickPanel.Name;
            ShowInfproduct(a);

        }
        private void ItemCart_Click(object sender, EventArgs e)
        {

            //int n = int.Parse(flowLayoutPanel1.Controls[0].Name);
            Panel clickPanel = (Panel)sender;
            string a = clickPanel.Name;
            ShowInfproduct(a);

        }
        private void ItemPrice_Click(object sender, EventArgs e)
        {

            //int n = int.Parse(flowLayoutPanel1.Controls[0].Name);
            Label clickPanel = (Label)sender;
            string a = clickPanel.Name;
            ShowInfproduct(a);

        }
        private void Item_Clicks(object sender, EventArgs e)
        {
            //chưa có data
            //System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            Button btn = (Button)sender;
            int productId = int.Parse(btn.Name);
            decimal price = btn.TabIndex;
            SqlData sql = new SqlData();
            DataRow dr = sql.GetAccountonline();
            int userId = int.Parse(dr["userID"].ToString());
            sql.Insert(userId, productId, productId, 1, price);
            //MessageBox.Show("Chưa có database!", "Thông báo", MessageBoxButtons.OK);
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
                new SqlData().LoginUser("online");
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

        private void button1_Click(object sender, EventArgs e)
        {

            TimKiem(button1.Text);
        }

        private void TimKiem(string str)
        {
            DataTable dt = new SqlData().Seclection();
            flowLayoutPanel1.Controls.Clear();


            foreach (DataRow row in dt.Rows)
            {
                string a = row["productName"].ToString().Trim();
                if (a.IndexOf(str) >= 0)
                {
                    ceat_cartprs(row["productName"].ToString(), row["price"].ToString(), row["productID"].ToString());
                }

            }
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(300, 300);
                pictureBox.Margin = new Padding(200, 80, 200, 80);
                FileStream fs = new System.IO.FileStream(@"C:\Users\ASUS\Source\Repos\QLBH-lastproject\QLBH-lastproject\img\404.jpg", FileMode.Open, FileAccess.Read);

                pictureBox.Image = Image.FromStream(fs);

                fs.Close();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


                flowLayoutPanel1.Controls.Add(pictureBox);

            }
        }
        private void timkiem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                //if(flowLayoutPanel1 == null)
                flowLayoutPanel1.Controls.Clear();
                Load_Data();
            }
            else
            {
                string b = textBox1.Text;
                string n = b.Substring(0, 1).ToUpper();
                string m = b.Substring(1);
                // string s = ;
                TimKiem(n + m);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimKiem(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimKiem(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimKiem(button4.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Load_Data();
        }
    }
}
