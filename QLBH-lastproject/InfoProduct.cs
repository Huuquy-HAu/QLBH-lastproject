using QLBH_lastproject.ConnectSql;
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
    public partial class InfoProduct : Form
    {
        public InfoProduct(int n)
        {
            InitializeComponent();
            
            // pictureBox.Size = new Size(140, 140);
            Image myimage = new Bitmap(@"C:\Users\ASUS\Pictures\langbac.jpg");
            pictureBox1.BackgroundImage = myimage;
            label2.Text = n.ToString();
            SqlData sql = new SqlData();
            DataTable dt = sql.Seclection(n);
            DataRow dataRow = dt.Rows[0];

            label2.Text = dataRow["productName"].ToString();
            string a = string.Format("{0:0,0}", int.Parse(dataRow["price"].ToString()));
            label3.Text = a + " VND";
            
            GetProDetail(n);
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
        private void InfoProduct_Load(object sender, EventArgs e)
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
            if (a == 0) { label8.Text = "1"; }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            int a = int.Parse(label8.Text);
            label8.Text = (a + 1).ToString();
            //if (a == 0) { label8.Text = "1"; }
        }
    }
}
