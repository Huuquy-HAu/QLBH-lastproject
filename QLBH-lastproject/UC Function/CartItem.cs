using QLBH_lastproject.ConnectSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_lastproject.UC_Function
{
    public partial class CartItem : UserControl
    {
        public CartItem(int n)
        {
            InitializeComponent();
            FileStream fs = new System.IO.FileStream(@"C:\Users\ntttr\Source\Repos\QLBH-lastproject\QLBH-lastproject\img\" + n + ".bmp", FileMode.Open, FileAccess.Read);

            pictureBox1.Image = Image.FromStream(fs);

            fs.Close();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = n.ToString();
            SqlData sql = new SqlData();
            DataTable dt = sql.Seclection(n);
            DataRow dataRow = dt.Rows[0];

            label1.Text = dataRow["productName"].ToString();
            string a = string.Format("{0:0,0}", int.Parse(dataRow["price"].ToString()));
            label3.Text = a + " VND";

            GetProDetail(n);
        }

        private void GetProDetail(int n)
        {
            SqlData sql = new SqlData();
            DataTable ds = sql.Seclections(n);
            DataRow dataRows = ds.Rows[0];
        }
    }
}
