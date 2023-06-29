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
    public partial class FUserInfor : Form
    {
        SqlData sql = new SqlData();
        public FUserInfor()
        {
            InitializeComponent();


        }

        private void FUserInfor_Load(object sender, EventArgs e)
        {
            DataRow dr = sql.GetAccountonline();
            textBox1.Text = dr["userID"].ToString();
            textBox2.Text = dr["userName"].ToString();
            textBox3.Text = dr["fullName"].ToString();
            textBox4.Text = dr["phone"].ToString();
            textBox5.Text = dr["address"].ToString();
            textBox3.PasswordChar = '\0';
            textBox4.PasswordChar = '\0';
            textBox5.PasswordChar = '\0';
            label1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label8.Text == "Đổi mật khẩu")
            {
                sql.UpdateUser(int.Parse(textBox1.Text), textBox3.Text, textBox4.Text, textBox5.Text);

            }
            else
            {
                if (textBox4.Text.Length > 6)
                {
                    if (textBox4.Text == textBox5.Text)
                    {
                        sql.UpdatePassWord(int.Parse(textBox1.Text), textBox4.Text);

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu xác nhận không chính xác!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu tối thiểu 6 ký tự!", "Thông báo", MessageBoxButtons.OK);
                }

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if(label8.Text == "Đổi mật khẩu")
            {
                clears();
                label4.Text = "Mật khẩu cũ";
                label5.Text = "Mật khẩu mới";
                label6.Text = "Xác nhận";
                button1.Name = "mk";
                label8.Text = "Quay lại";
                textBox3.Focus();
            }else
            {
                label8.Text = "Đổi mật khẩu";
                label4.Text = "Họ và tên";
                label5.Text = "Số điện thoại";
                label6.Text = "Địa chỉ";
                FUserInfor_Load(sender,e);
            }
            
        }
        private void clears()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
            textBox5.PasswordChar = '*';
        }
    }
}
