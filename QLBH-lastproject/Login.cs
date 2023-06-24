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
            DataTable dt = sql.SeclectUser(textBox1.Text, textBox2.Text);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Thông tin tài khoản không chính xác!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                //cập nhật trạng thái online + phân vai trò
                //dt = sql.SeclectionRole(int.Parse(dt.Rows[0]["roleID"].ToString()));
                //
                this.Hide();
                new Mainmenu().Show(this);
            }
        }
    }
}
