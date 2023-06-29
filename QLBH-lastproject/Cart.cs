using QLBH_lastproject.ConnectSql;
using QLBH_lastproject.UC_Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QLBH_lastproject
{
    public partial class Cart : Form
    {
        SqlData sql = new SqlData();
        public Cart()
        {
            InitializeComponent();
            label1.Name = sql.GetAccountonline()["userID"].ToString();
        }
        private void Cart_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sql.getallOrder(int.Parse(label1.Name));
            dataGridView1.Columns["btn_Xoa"].DisplayIndex = dataGridView1.ColumnCount - 1;
            dataGridView1.Columns["btn_Down"].DisplayIndex = 7;
            dataGridView1.Columns["btn_Up"].DisplayIndex = 8;
            dataGridView1.Columns["check"].DisplayIndex = 0;
            dataGridView1.Columns["orderID"].HeaderText = "Mã đơn";
            dataGridView1.Columns["productName"].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns["quantity"].HeaderText = "Số lượng";
            dataGridView1.Columns["Price1"].HeaderText = "Thành tiền";
            dataGridView1.Columns["price"].HeaderText = "Đơn giá";
            TinhTien();

        }


        private void TinhTien()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[3];
                if (chk.Value != chk.TrueValue)
                {
                    sum += int.Parse(row.Cells[10].Value.ToString());

                }
            }
            pricelabel.Text = sum.ToString();
        }


        private void thanhtoan_Click(object sender, EventArgs e)
        {
            int s;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[3];
                if (chk.Value != chk.TrueValue)
                {
                    s = int.Parse(row.Cells[4].Value.ToString());
                    thanhtoan.Text = s.ToString();
                    sql.UpdatestatusOrder(int.Parse(thanhtoan.Text));
                    sql.InserMualai(int.Parse(label1.Name), DateTime.Now, 0, s);

                }
            }
            dataGridView1.DataSource = sql.getallOrder(int.Parse(label1.Name));
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void trolai_Click_2(object sender, EventArgs e)
        {
            int s = int.Parse(sql.GetAccountonline()["roleID"].ToString());
            new Mainmenu(s).Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_Xoa")
            {
                if (MessageBox.Show("Bạn muốn xóa đơn hàng ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var s = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    thanhtoan.Text = s;
                    sql.DeleteOrder(int.Parse(s));
                    dataGridView1.DataSource = sql.getallOrder(int.Parse(label1.Name));

                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_Down")
            {

                var s = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                var id = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                var price = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                int total = int.Parse(s);
                total -= 1;
                int thanhtien = total * int.Parse(price);
                //dataGridView1.Rows[e.RowIndex].Cells[9].Value = total.ToString();

                dataGridView1.Rows[e.RowIndex].Cells[9].Value = total.ToString();
                dataGridView1.Rows[e.RowIndex].Cells[10].Value = thanhtien;
                sql.UpdateTotalOrder(total, int.Parse(id), thanhtien);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "btn_Up")
            {
                var s = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                var price = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                int total = int.Parse(s);
                total += 1;
                int thanhtien = total * int.Parse(price);
                dataGridView1.Rows[e.RowIndex].Cells[9].Value = total;
                dataGridView1.Rows[e.RowIndex].Cells[10].Value = thanhtien;
                var id = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                //thanhtoan.Text = price.ToString();

                sql.UpdateTotalOrder(total, int.Parse(id), thanhtien);

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "check")
            {
                //DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridView1.Rows[e.RowIndex].Cells[3];
                if (dataGridView1.Rows[e.RowIndex].Cells[3].Value == null)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = true;
                    TinhTien();
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = null;
                    TinhTien();
                }

            }

        }
    }
}
