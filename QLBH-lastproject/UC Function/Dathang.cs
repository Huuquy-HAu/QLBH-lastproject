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
<<<<<<< HEAD
=======
        SqlConnection connection;
        SqlCommand command;
        SqlCommand cmd;

        private string str = "Data Source =.\\sqlexpress;Initial Catalog = QLBH_WPF; Integrated Security = True; trustServerCertificate = true";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();


        public void loadData1()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT [CartID], [UserID], [CreateAt], [cartStatusID], [orderID] FROM [Cart]";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView2.DataSource = table;

        }

        public void UpdateOrderID(int orderId)
        {
            orderID = orderId;

            // Update the UI controls with the new orderID value
            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows[0].Cells["orderID"].Value = orderId;
                loadData1();
            }
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                string id = selectedRow.Cells["orderID"].ToString();
            }

            // Load cart items for the selected orderID
            //adapter.SelectCommand = new SqlCommand("SELECT * FROM [Cart] WHERE orderID = @orderId", connection);
            //adapter.SelectCommand.Parameters.AddWithValue("@orderId", orderId);

        }
        void loadData2()
        {
            command = connection.CreateCommand();
            command.CommandText = "select CartStatusName from [CartStatus] where CartStatusID = '1'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView2.DataSource = table;

        }
        void loadData3()
        {
            command = connection.CreateCommand();
            command.CommandText = "select CartStatusName from [CartStatus] where CartStatusID = '2'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView2.DataSource = table;

        }
        void loadData4()
        {
            command = connection.CreateCommand();
            command.CommandText = "select CartStatusName from [CartStatus] where CartStatusID = '3'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView2.DataSource = table;

        }
>>>>>>> 938d915d2cd6bb4b5d97935b7baa0cd22c2c5ebf
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

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Visible = false;
            //MessageBox.Show("Đã hủy đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
=======
            if (!button1Clicked || !button2Clicked)
            {
                connection = new SqlConnection(str);
                loadData4();
                button1Clicked = true;
                button2Clicked = true;
                MessageBox.Show("Đã hủy đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
>>>>>>> 938d915d2cd6bb4b5d97935b7baa0cd22c2c5ebf

        }
        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //MessageBox.Show("Đã xác nhận thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Visible = false;
=======
            if (!button2Clicked || !button1Clicked)
            {
                connection = new SqlConnection(str);
                loadData3();
                button1Clicked = true;
                button2Clicked = true;
                MessageBox.Show("Đã xác nhận thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }

>>>>>>> 938d915d2cd6bb4b5d97935b7baa0cd22c2c5ebf
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
