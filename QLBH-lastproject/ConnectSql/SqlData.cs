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
        private string connetionString = @"Data Source=.\sqlexpress;Initial Catalog=QLBH_WPF;Integrated Security=True";
        private SqlConnection conn;
        private string sql;
        private SqlCommand cmd;
        private DataTable dt;

        public SqlData()
        {
            try
            {
                conn = new SqlConnection(connetionString);
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
        public Boolean Insert(int a, int b, int c, int d , int e , decimal f)
        {
            try
            {
                conn.Open();
                sql = @"INSERT INTO [Order] (OrderID,userID,productID,productDetailID,quantity,Price) VALUES (@OrderID,@userID,@productID,@productDetailID,@quantity,@Price)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@OrderID", SqlDbType.Int).Value = a;
                cmd.Parameters.Add("@userID", SqlDbType.Int).Value = b;

                //a longer syntax for adding parameters
                cmd.Parameters.Add("@productID", SqlDbType.Int).Value = c;
                cmd.Parameters.Add("@productDetailID", SqlDbType.Int).Value = d;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = e;
                cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = f;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { conn.Close(); }
        }
        public DataTable SeclectionRole(int i) // sql cập nhật trạng thái onl/off +phân vai trò
        {
            try
            {
                conn.Open();
                sql = @"select * from [Role] where @userID = userID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", i);
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
        public DataTable getallCart()
        {
            try
            {
                conn.Open();
                sql = @"select* from [Cart]";
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
        public DataTable SeclectCart(int i)
        {
            try
            {
                conn.Open();
                sql = @"select * from [Cart] where @CartID = CartID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CartID", i);
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
        
        public DataTable getallOrder(int i)
        {
            try
            {
                conn.Open();
                sql = @"select * from [Order] where @OrderID = OrderID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@OrderID", i);
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
        public DataTable SeclectOrder(int i)
        {
            try
            {
                conn.Open();
                sql = @"select * from [Order] where @UserID = UserID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserID", i);
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
