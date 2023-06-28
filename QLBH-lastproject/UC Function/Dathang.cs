using QLBH_lastproject.ConnectSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_lastproject.UC_Function
{
    public partial class Dathang : UserControl
    {
        public Dathang()
        {
            InitializeComponent();
            SqlData sql = new SqlData();
            label1.Name = sql.GetAccountonline()["userID"].ToString();
        }
        private string GetCurrentDateTime()
        {
            DateTime dt = DateTime.Now;
            return dt.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void Dathang_Load(object sender, EventArgs e)
        {
            SqlData sql = new SqlData();


            int i = int.Parse(label1.Name);
            dataGridView2.DataSource = sql.GetCartUser(i);
            dataGridView2.Columns["cartID"].HeaderText = "Mã đơn hàng";
            dataGridView2.Columns["productName"].HeaderText = "Tên sản phẩm";
            dataGridView2.Columns["quantity"].HeaderText = "Số lượng";
            dataGridView2.Columns["Price"].HeaderText = "Thành tiền";
            dataGridView2.Columns["CreateAt"].HeaderText = "Ngày đặt";
            dataGridView2.Columns["status"].HeaderText = "Trạng thái";

            dataGridView2.Columns["btn_Table"].DisplayIndex = dataGridView2.Columns.Count - 1;

        }


        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            //dataGridView2.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;

        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString() == "Chưa duyệt")
            {
                dataGridView2.Rows[e.RowIndex].Cells[0].Value = "Hủy";
            }
            else
            {
                dataGridView2.Rows[e.RowIndex].Cells[0].Value = "Mua lại";
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "btn_Table")
            {
                if (dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() == "Hủy")
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn hủy!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        var s = dataGridView2.Rows[e.RowIndex].Cells[1].Value;
                        SqlData sql = new SqlData();
                        sql.UpdateStatusCart((int)s, 2);
                        MessageBox.Show("hủy thành công");
                        Dathang_Load(sender, e);
                    }
                }
                else
                {
                    //string a =  dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                    var s = dataGridView2.Rows[e.RowIndex].Cells[1].Value;
                    SqlData sql = new SqlData();
                    //button1.Text = s.ToString();
                    //DataRow dr = sql.GetAccountonline();
                    //int i = int.Parse(dr["userID"].ToString());
                    int i = int.Parse(label1.Name);
                    DateTime dt = DateTime.Now;
                    int idOrder = sql.GetIdOrder((int)s);
                    sql.InserMualai(i, dt, 0, idOrder);
                    MessageBox.Show("Đặt đơn hàng thành công");
                    Dathang_Load(sender, e);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dathang_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlData sql = new SqlData();
            dataGridView2.DataSource = sql.FilterCartUser(0, int.Parse(label1.Name));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlData sql = new SqlData();
            dataGridView2.DataSource = sql.FilterCartUser(1, int.Parse(label1.Name));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlData sql = new SqlData();
            dataGridView2.DataSource = sql.FilterCartUser(2, int.Parse(label1.Name));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlData sql = new SqlData();
            dataGridView2.DataSource = sql.FilterCartUser(3, int.Parse(label1.Name));
        }
    }
}
