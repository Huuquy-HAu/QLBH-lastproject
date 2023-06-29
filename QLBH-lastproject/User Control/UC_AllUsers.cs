using QLBH_lastproject;
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

namespace WinFormsApp1
{
    public partial class UC_AllUsers : UserControl
    {
        public UC_AllUsers()
        {
            InitializeComponent();
            LoadData();
            LoadRole();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            if (panel != null)
            {
                panel.Controls.Clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadData()
        {
            List<Account> accountList = Account.GetAllAccounts();

            dataGridView1.DataSource = accountList;

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = 200; // Đặt kích thước cố định cho mỗi cột thành 200 pixels
            }
            dataGridView1.RowTemplate.Height = 50;

        }


        public void LoadRole()
        {
            Account account = Account.Instance;
            List<string> roles = account.GetAllRoles();

            // Gán danh sách vai trò vào ComboBox
            cbRoleUser.DataSource = roles;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "roleID")
            {
                Console.WriteLine(e.Value); // In giá trị của e.Value để kiểm tra

                // ...Các lệnh khác
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột của hàng được chọn
                int userID = int.Parse(row.Cells["userID"].Value.ToString());
                string userName = row.Cells["userName"].Value.ToString();
                string password = row.Cells["password"].Value.ToString();
                int roleID = int.Parse(row.Cells["roleID"].Value.ToString());


                // Đặt dữ liệu vào TextBox hoặc các điều khiển khác
                inpID.Text = userID.ToString();
                inpUserName.Text = userName;
                inpPassword.Text = password;
                cbRoleUser.SelectedIndex = roleID - 1;
            }
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            inpID.Text = string.Empty;
            inpUserName.Text = string.Empty;
            inpPassword.Text = string.Empty;
            cbRoleUser.SelectedIndex = 0;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frAddNewUser frAddNewUser = new frAddNewUser();
            frAddNewUser.ShowDialog();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            int UserId = int.Parse(inpID.Text);
            string password = inpPassword.Text;
            int roleId = cbRoleUser.SelectedIndex + 1;
            if (string.IsNullOrEmpty(inpPassword.Text))
            {
                MessageBox.Show("Không được để trống thông tin !");
                return;
            }

            account.UpdateAccount(password, roleId, UserId);
            LoadData();
            MessageBox.Show("Đổi thông tin thành công!");
        }
    }
}
