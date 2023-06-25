using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_lastproject.ConnectSql
{
     public class SqlData
     {
        private string connetionString = "Data Source =localhost;Initial Catalog = QLBH_WPF;User ID = sa;Password = 12345";
        private string connectionStringNopassword = "Data Source=.\\sqlexpress;Initial Catalog=QLBH_WPF;Integrated Security=True; trustServerCertificate = true";
        private SqlConnection conn;
        private string sql;
        private SqlCommand cmd;
        private DataTable dt;

        public SqlData()
        {
            try
            {
                conn = new SqlConnection(connectionStringNopassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable Seclection()
        {
            try
            {
                conn.Open();
                sql = @"select* from [Product]";
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public DataTable Seclection(int i)
        {
            try
            {
                conn.Open();
                sql = @"select * from [Product] where @productID = productID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@productID", i);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public DataTable Seclection(string i)
        {
            try
            {
                conn.Open();
                sql = @"select * from [Product] where @productName = productName";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@productName", i);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public DataTable Seclections(int i)
        {
            try
            {
                conn.Open();
                sql = @"select * from [ProductDetail] where @productID = productID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@productID", i);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }

        public DataTable SeclectUser(string u, string p)
        {
            try
            {
                conn.Open();
                sql = @"select* from [User] where @userName = userName  AND @password =  password ";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", u);
                cmd.Parameters.AddWithValue("@password", p);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
    }
}
