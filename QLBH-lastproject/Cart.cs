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

        private string str = "Data Source=.\\sqlexpress;Initial Catalog=QLBH_WPF;Integrated Security=True; trustServerCertificate = true";
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
            userControl.Dock = DockStyle.Fill;
            PnlMain.Controls.Clear();
            PnlMain.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public delegate void OrderIDChangedEventHandler(int orderId);
        public event OrderIDChangedEventHandler OrderIDChanged;
        private void tinhtong()
        {
            int t = int.Parse(label13.Text);
            int n = int.Parse(textBox5.Text);
            int p = t * n;
            pricelabel.Text = p.ToString();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dataGridView1.CurrentRow.Index;
            int price = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            int quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            double totalPrice = price * quantity;
            pricelabel.Text = totalPrice.ToString() + " VND";
            label10.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            label11.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            label12.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            label13.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private bool m = false;
        private void Editquantity()
        {
            if(textBox5.Text == "" ) {
                
            }
            else
            {
                int i = dataGridView1.CurrentRow.Index;
                int orderID = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                int quantity = Convert.ToInt32(textBox5.Text);
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE [Order] SET quantity = " + quantity + " WHERE OrderID = " + orderID;
                cmd.ExecuteNonQuery();
                loadData();
                int price = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                int quan = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                double totalPrice = price * quan;
                pricelabel.Text = totalPrice.ToString() + " VND";
            }
            
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Editquantity();
        }

        private void thanhtoan_Click(object sender, EventArgs e)
        {
            if (pricelabel.Text == "" || pricelabel.Text == "0")
            {
                MessageBox.Show("Chưa chọn mã giỏ hàng!", "Không thể đặt hàng", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else if (textBox5.Text == "0" || textBox5.Text == "")
            {
                MessageBox.Show("Vui lòng thêm số lượng!", "Không thể đặt hàng", MessageBoxButtons.OK, MessageBoxIcon.None);
                return;
            }
            else
            {
                Dathang dathang = new Dathang();
                addCartItem(dathang);
                conn = new SqlConnection(str);
                conn.Open();
                int selectedValue = int.Parse(label10.Text);

                cmd.CommandText = "SELECT OrderID FROM [Order] WHERE OrderID = " + selectedValue;
                cmd.ExecuteNonQuery();
                loadData();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int orderId = int.Parse(selectedRow.Cells["OrderID"].Value.ToString());
                    dathang.UpdateOrderID(orderId);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from [Order] where OrderID = '" + label10.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
            pricelabel.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            textBox5.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
