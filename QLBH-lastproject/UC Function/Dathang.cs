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
        SqlConnection connection;
        SqlCommand command;
        SqlCommand cmd;

        string str = "Data Source=NTT0701\\SQLEXPRESS;Initial Catalog=QLBH_WPF;Integrated Security=True; TrustServerCertificate=true";
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
            dataGridView2.Text = orderId.ToString();

            // Load cart items for the selected orderID
            adapter.SelectCommand = new SqlCommand("SELECT * FROM [Cart] WHERE orderID = @orderId", connection);
            adapter.SelectCommand.Parameters.AddWithValue("@orderId", orderId);
            table.Clear();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
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
        public Dathang()
        {
            InitializeComponent();
        }
        private string GetCurrentDateTime()
        {
            DateTime dt = DateTime.Now;
            return dt.ToString("yyyy-MM-dd hh:mm:ss");
        }
        private void AddToCart(int userID, int cartStatusID, int orderID)
        {
            try
            {
                string query = "INSERT INTO [Cart] ([CreateAt]) VALUES (@CreateAt)";
                using (SqlConnection connection = new SqlConnection(str))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CreateAt", GetCurrentDateTime());
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                loadData1();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Dathang_Load(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            connection = new SqlConnection(str);
            loadData1();
            loadData2();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private bool button1Clicked = false;
        private bool button2Clicked = false;
        internal static int orderID;

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1Clicked || button2Clicked) return;
            connection = new SqlConnection(str);
            loadData4();
            button1Clicked = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2Clicked || button1Clicked) return;
            connection = new SqlConnection(str);
            loadData3();
            button2Clicked = true;
        }
    }
}
