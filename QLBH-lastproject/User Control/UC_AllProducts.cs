using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace WinFormsApp1
{
    public partial class UC_AllProducts : UserControl
    {
        string strCon = @"Data Source=.\sqlexpress;Initial Catalog=QLBH_WPF;Integrated Security=True";

        SqlConnection sqlCon = null;
        SqlCommand sqlCmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        int a = 3;
        public UC_AllProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            if (panel != null)
            {
                panel.Controls.Clear();
            }

            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        private void UC_AllProducts_Load(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }

                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void loadData()
        {
            sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandText = "select * from Product";
            da.SelectCommand = sqlCmd;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Font = new Font("Arial", 11);
        }

        void clearValue()
        {
            txtProID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtDescription.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;

            txtProID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDescription.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtPrice.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && validPrice())
            {
                sqlCmd = sqlCon.CreateCommand();
                sqlCmd.CommandText = "INSERT INTO Product(productName, description, price) VALUES" +
                "('" + txtName.Text + "','" + txtDescription.Text + "','" + txtPrice.Text + "')";
                sqlCmd.ExecuteNonQuery();

                loadData();
                MessageBox.Show("Add successful!", "Message", MessageBoxButtons.OK);
                clearValue();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hợp lệ!", "Message", MessageBoxButtons.OK);
            }


        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                sqlCmd = sqlCon.CreateCommand();
                sqlCmd.CommandText = "DELETE FROM Product WHERE productName= '" + txtName.Text + "'";
                sqlCmd.ExecuteNonQuery();

                loadData();
                clearValue();
            }

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) && validPrice())
            {
                sqlCmd = sqlCon.CreateCommand();
                sqlCmd.CommandText = "update Product set productName = N'" + txtName.Text + "',description = N'" + txtDescription.Text + "',price = N'" + txtPrice.Text + "' where productID = '" + txtProID.Text + "'";
                sqlCmd.ExecuteNonQuery();

                loadData();
                MessageBox.Show("Update successful!", "Message", MessageBoxButtons.OK);
            }

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtName, "Please enter product name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, null);
            }
        }

        private bool validPrice()
        {
            string price = txtPrice.Text;
            string priceN = price.Substring(0,price.Length - 1);
            int priceNum = 0;
            if (price.Length > 0)
            {
                priceNum = int.Parse(priceN);
                if (priceNum < 0)
                {
                    MessageBox.Show("Product price must be positive!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return false;
                }
            }
            return true;
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                e.Cancel = true;
                txtPrice.Focus();
                errorProvider1.SetError(txtPrice, "Please enter product price!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, null);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                txtDescription.Focus();
                errorProvider1.SetError(txtDescription, "Please enter product description!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, null);
            }
        }
    }
}
