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
        SqlConnection conn;
        SqlCommand cmd;

        string str = "Data Source=NTT0701\\SQLEXPRESS;Initial Catalog=QLBH_WPF;Integrated Security=True; TrustServerCertificate=true";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from [Order]";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        public Cart()
        {
            InitializeComponent();
        }

        private void trolai_Click(object sender, EventArgs e)
        {
            Mainmenu mainmenu = new Mainmenu();
            this.Hide();
            mainmenu.Show();
            mainmenu.BringToFront();
        }
        private void trolai_Click_1(object sender, EventArgs e)
        {
            Mainmenu mainmenu = new Mainmenu();
            this.Hide();
            mainmenu.Show();
            mainmenu.BringToFront();
        }
        private void Cart_Load_1(object sender, EventArgs e)
        {

            conn = new SqlConnection(str);
            conn.Open();
            loadData();
        }
        private void addCartItem(UserControl userControl)
        {

            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void thanhtoan_Click_1(object sender, EventArgs e)
        {
            if (pricelabel.Text == "")
            {
                MessageBox.Show("Chưa chọn mã giỏ hàng!", "Không thể đặt hàng", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else if (textBox5.Text == "0")
            {
                MessageBox.Show("Vui lòng thêm số lượng!", "Không thể đặt hàng", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {

                addCartItem(new Dathang());
                conn = new SqlConnection(str);
                int selectedValue = int.Parse(textBox1.Text);
                cmd.CommandText = "SELECT OrderID FROM [Order] WHERE OrderID = " + selectedValue;
                cmd.ExecuteNonQuery();
                loadData();
            }
        }
        public delegate void OrderIDChangedEventHandler(int orderId);
        public event OrderIDChangedEventHandler OrderIDChanged;

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            pricelabel.Text = dataGridView1.Rows[i].Cells[5].Value.ToString() + "  VND";
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            //if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["OrderID"].Index)
            //{
            //DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //int orderId = (int)row.Cells["OrderID"].Value;
            //Dathang.Update(orderId);
            //}

        }


        //private void thembtn_Click_1(object sender, EventArgs e)
        //{
        //int cartid = int.Parse(textBox1.Text);
        //int userid = int.Parse(textBox2.Text);
        //int createat = int.Parse(textBox3.Text);
        //int orderid = int.Parse(textBox4.Text);
        //getcart = new getCart(cartid, userid, createat, orderid);
        //if (SqlData.Insertcart(getCart))
        //{
        //dataGridView1.DataSource = data.getallCart();
        //}
        //else
        //{
        //MessageBox.Show("Xay ra loi : ", "Khong sua duoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //cmd = conn.CreateCommand();
        //cmd.CommandText = "insert into dbo.Cart values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "')";
        //cmd.ExecuteNonQuery();
        //loadData();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //int cartid = int.Parse(textBox1.Text);
        //int userid = int.Parse(textBox2.Text);
        //int createat = int.Parse(textBox3.Text);
        //int orderid = int.Parse(textBox4.Text);
        //getcart = new getCart(cartid, userid, createat, orderid);
        //if (SqlData.Update(getCart))
        //{
        //dataGridView1.DataSource = data.getallCart();
        //}
        //else
        //{
        //MessageBox.Show("Xay ra loi : ", "Khong sua duoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        //cmd = conn.CreateCommand();
        //cmd.CommandText = "update dbo.Cart set UserID = '" + textBox2.Text + "', CreateAt = '" + textBox3.Text + "', orderID = '" + textBox4.Text + "' where CartID = '" + textBox1.Text + "'";
        //cmd.ExecuteNonQuery();
        //loadData();
        //}

        private void button2_Click_1(object sender, EventArgs e)
        {

            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from dbo.Dathang where OrderID = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
            pricelabel.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
