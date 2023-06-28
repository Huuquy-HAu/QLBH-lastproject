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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            SqlData sql = new SqlData();
            label1.Name = "nv";
            dataGridView1.DataSource = sql.SeclectStaffCart(1);
            dataGridView1.Columns["CartID"].HeaderText = "Mã đơn hàng";
            dataGridView1.Columns["fullName"].HeaderText = "Tên khách hàng";
            dataGridView1.Columns["CreateAt"].HeaderText = "Ngày đặt";
            dataGridView1.Columns["status"].HeaderText = "Trạng thái";
            dataGridView1.Columns["address"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["CreateAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlData sql = new SqlData();
            label1.Name = "cs";
            dataGridView1.DataSource = sql.SeclectStaffCart(3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff_Load(sender,e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "status" && label1.Name == "nv" )
            {
                var s = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if( MessageBox.Show("Bạn đã hoàn thành nhiệm vụ !","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlData sql = new SqlData();
                    sql.UpdateStatusCart((int)s, 3);
                    Staff_Load(sender,e);
                }
            }
        }
    }
}
