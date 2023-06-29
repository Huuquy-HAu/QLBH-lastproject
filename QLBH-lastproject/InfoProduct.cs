using Microsoft.VisualBasic.ApplicationServices;
using QLBH_lastproject.ConnectSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_lastproject
{
    public partial class InfoProduct : Form
    {
        public InfoProduct(int n, string m, int cartId)
        {
            InitializeComponent();
            SqlData sql = new SqlData();
            DataTable dt = new DataTable();
            DataRow dataRow = null;
            string price;
            pictureBox1.Name = cartId.ToString();
            if (m != "info")
            {
                label1.Text = "Thông tin đơn đặt";

                dt = sql.getallOrder(n);
                dataRow = dt.Rows[0];
                n = int.Parse(dataRow["productID"].ToString());
                //price = (dataRow["Price"].ToString());
                label8.Text = dataRow["quantity"].ToString();
                label7.Visible = false;
                label9.Visible = false;
                if (m.Length == 10)
                {
                    button1.Text = "Duyệt";
                    button2.Text = "Hủy";
                    label15.ForeColor = Color.Red;
                }
                else
                {
                    button1.Visible = false;
                    button2.Visible = false;
                }

                //label14.Text = string.Format("{0:0,0}", price) ;
                label15.Text = m; // da 8 chua 10 
            }
            else
            {
                label15.Visible = false;
            }


            // pictureBox.Size = new Size(140, 140);
            //n
            FileStream fs = new System.IO.FileStream(@"D:\CS project\QLBH_Test\QLBH-lastproject\QLBH-lastproject\img\" + n + ".bmp", FileMode.Open, FileAccess.Read);
            pictureBox1.Image = Image.FromStream(fs);
            fs.Close();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = n.ToString();


            dt = sql.Seclection(n);
            dataRow = dt.Rows[0];

            label2.Text = dataRow["productName"].ToString();
            label3.Name = dataRow["price"].ToString();
            price = string.Format("{0:0,0}", int.Parse(label3.Name));
            label3.Text = price + " VND";

            int b = (int.Parse(label8.Text) * int.Parse(dataRow["price"].ToString()));
            label14.Text = string.Format("{0:0,0}", b);
            label14.Name = b.ToString();
            GetProDetail(n);
            label1.Name = n.ToString();
        }

        private void GetProDetail(int n)
        {
            //InitializeComponent();
            //label2.Text = n.ToString();
            SqlData sql = new SqlData();
            DataTable ds = sql.Seclections(n);
            DataRow dataRows = ds.Rows[0];
            label11.Text = dataRows["Ram"].ToString();
            label12.Text = dataRows["Rom"].ToString();
        }
        private void InfoProduct_Load(object sender, EventArgs e, int n)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            int a = int.Parse(label8.Text);
            label8.Text = (a - 1).ToString();
            int b = (int.Parse(label8.Text) * int.Parse(label3.Name));
            label14.Text = string.Format("{0:0,0}", b);
            if (a == 0) { label8.Text = "1"; }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            int a = int.Parse(label8.Text);
            label8.Text = (a + 1).ToString();
            int b = (int.Parse(label8.Text) * int.Parse(label3.Name));
            label14.Text = string.Format("{0:0,0}", b);
            //if (a == 0) { label8.Text = "1"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlData sql = new SqlData();
            if (button2.Text == "Mua ngay")
            {
                this.Close();
            }
            else
            {
                sql.UpdateStatusCart(int.Parse(pictureBox1.Name), 2);
                this.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlData sql = new SqlData();
            if (button1.Text == "Thêm vào giỏ hàng")
            {
                DataRow dr = sql.GetAccountonline();
                int userId = int.Parse(dr["userID"].ToString());
                sql.Insert(userId, int.Parse(label1.Name), int.Parse(label1.Name), int.Parse(label8.Text), decimal.Parse(label14.Text));
            }
            else
            {
                if (sql.UpdateStatusCart(int.Parse(pictureBox1.Name), 1))
                {
                    this.Close();
                }

            }
        }
    }
}
