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

namespace WinFormsApp1.UC
{
    public partial class UC_AllOrders : UserControl
    {
        public UC_AllOrders()
        {
            InitializeComponent();
            Load_Data();
        }
        private void Load_Data()
        {
            SqlData sql = new SqlData();
            dataGridView1.DataSource = sql.getallCart();
            dataGridView1.Columns["CartID"].HeaderText = "Mã đơn hàng";
            dataGridView1.Columns["userName"].HeaderText = "Tên tài khoản";
            dataGridView1.Columns["CreateAt"].HeaderText = "Ngày đặt";
            dataGridView1.Columns["status"].HeaderText = "Trạng thái";
            dataGridView1.Columns["orderID"].HeaderText = "Mã đơn đặt ";


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[4].Value.ToString());
            var m = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();
            new InfoProduct(n, m).Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlData sqlData = new SqlData();
            dataGridView1.DataSource = sqlData.SeclectCart(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlData sqlData = new SqlData();
            dataGridView1.DataSource = sqlData.SeclectCart(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlData sqlData = new SqlData();
            dataGridView1.DataSource = sqlData.SeclectCart(2);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
