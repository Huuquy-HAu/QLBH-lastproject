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
        SqlData data;
        getCart getcart;
        string str = "Data Source=NTT0701\\SQLEXPRESS;Initial Catalog=QLBH_WPF;Integrated Security=True; TrustServerCertificate=true";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from dbo.Cart";
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
            data = new SqlData();
            dataGridView1.DataSource = data.getallCart();
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
            addCartItem(new Dathang());



        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void thembtn_Click_1(object sender, EventArgs e)
        {
            int cartid = int.Parse(textBox1.Text);
            int userid = int.Parse(textBox2.Text);
            int createat = int.Parse(textBox3.Text);
            int orderid = int.Parse(textBox4.Text);
            getcart = new getCart(cartid, userid, createat, orderid);
            if (SqlData.Insertcart)
            {
                dataGridView1.DataSource = data.getallCart();
            }
            else
            {
                MessageBox.Show("Xay ra loi : ", "Khong sua duoc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //cmd = conn.CreateCommand();
            //cmd.CommandText = "insert into dbo.Cart values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "')";
            //cmd.ExecuteNonQuery();
            //loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "update dbo.Cart set UserID = '" + textBox2.Text + "', CreateAt = '" + textBox3.Text + "', orderID = '" + textBox4.Text + "' where CartID = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from dbo.Cart where CartID = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
