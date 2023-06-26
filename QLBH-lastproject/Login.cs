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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlData sql = new SqlData();
            if (!sql.LoginUser(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Thông tin tài khoản không chính xác!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataRow dr = sql.GetAccountonline();
                int s = int.Parse(dr["roleID"].ToString());
                if (s == 3)
                {
                    sql.LoginUser("online");
                    //MessageBox.Show("Tài khoản này đang tạm khóa!\n Vui lòng liên hệ hotline: 0987503481 để được hỗ trợ", "Thông báo", MessageBoxButtons.OK);
                    MessageBox.Show("Tài khoản này đang tạm khóa!\n Vui lòng liên hệ A Hoàng để được hỗ trợ", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    this.Hide();
                    new Mainmenu(s).Show(this);
                }
            }
        }
    }
}
