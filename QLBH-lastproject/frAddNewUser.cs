using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frAddNewUser : Form
    {
        public frAddNewUser()
        {
            InitializeComponent();
            LoadRole();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void LoadRole()
        {
            Account account = Account.Instance;
            List<string> roles = account.GetAllRoles();

            // Gán danh sách vai trò vào ComboBox
            comboBox1.DataSource = roles;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inpUserName.Text = string.Empty;
            inpPasswod.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            string UserName = inpUserName.Text;
            string password = inpPasswod.Text;
            int roleId = comboBox1.SelectedIndex + 1;
            if (string.IsNullOrEmpty(inpUserName.Text) || string.IsNullOrEmpty(inpPasswod.Text)) {
                MessageBox.Show("Không được bỏ trống thông tin !");
                return;
            }

            account.AddAccount(UserName, password, roleId);
            MessageBox.Show("Thêm người dùng thành công!");
            this.Hide();


        }
    }
}
