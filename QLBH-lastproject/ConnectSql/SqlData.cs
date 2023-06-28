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

        public DataRow LoginUser(string u, string p)
        {
           
            try
            {
                conn.Open();
                sql = @"select * from [User] where @userName = userName  AND @password =  password ";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userName", u);
                cmd.Parameters.AddWithValue("@password", p);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                DataRow dataRow = dt.Rows[0];
                return dataRow;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public Boolean SetStatus(string status )
        {

            try
            {
                conn.Open();
                sql = @"update [User] set status = @status where  @sta = status";
                cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@sta", status);
                cmd.Parameters.AddWithValue("@status", "offline");
    
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
        public Boolean SetStatus(int status)
        {

            try
            {
                conn.Open();
                sql = @"update [User] set status = @status where  @sta = userID";
                cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@sta", status);
                cmd.Parameters.AddWithValue("@status", "online");

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
        public DataRow GetAccountonline()
        {

            try
            {
                conn.Open();
                sql = @"select *from [User]  where  @sta = status";
                cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@sta", "online");
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                DataRow dataRow = dt.Rows[0];

                return dataRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public Boolean Insert( int b, int c, int d , int e , decimal f)
        {
            try
            {
                conn.Open();
                sql = @"INSERT INTO [Order] (userID,productID,productDetailID,quantity,Price) VALUES (@userID,@productID,@productDetailID,@quantity,@Price)";
                cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.Add("@userID", SqlDbType.Int).Value = b;

                //a longer syntax for adding parameters
                cmd.Parameters.Add("@productID", SqlDbType.Int).Value = c;
                cmd.Parameters.Add("@productDetailID", SqlDbType.Int).Value = d;
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = e;
                cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = f;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thông báo", "Thêm vào giỏ hàng thành công!", MessageBoxButtons.OK);
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
                /*sql = @"select CartID,UserID,CreateAt,
                case  
                    when cartStatusID = 0 then 'Chưa duyệt' else N'Đã duyệt'
                end as status
                ,orderID from [Cart]";*/

                sql = @"SELECT CartID, userName, CreateAt,
                case  
                    when cartStatusID = 0 then N'Chưa duyệt' 
                    when cartStatusID = 1 then N'Đã duyệt'
                    when cartStatusID = 2 then N'Đã hủy'
                    else N'Hoàn thành'
                end as status
                , orderID  
                FROM [Cart]  
                LEFT JOIN [User] 
                ON [Cart].UserID= [User].UserID 
                ";

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
                /*sql = @"select CartID,UserID,CreateAt,
                case  
                    when cartStatusID = 0 then 'Chưa duyệt' else N'Đã duyệt'
                end as status
                ,orderID from [Cart]";*/

                sql = @"SELECT p.CartID, u.userName, p.CreateAt,
                case  
                    when p.cartStatusID = 0 then N'Chưa duyệt' 
                    when p.cartStatusID = 1 then N'Đã duyệt' 
                    when p.cartStatusID = 2 then N'Đã hủy' 
                    else N'Hoàn thành'
                end as status
                , p.orderID  
                FROM [Cart] AS p  
                LEFT JOIN [User] AS u 
                ON p.UserID= u.UserID 
                WHERE @cartStatusID = cartStatusID
                ";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cartStatusID", i);
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
        public DataTable SeclectStaffCart(int i)
        {
            try
            {
                conn.Open();
                /*sql = @"select CartID,UserID,CreateAt,
                case  
                    when cartStatusID = 0 then 'Chưa duyệt' else N'Đã duyệt'
                end as status
                ,orderID from [Cart]";*/

                sql = @"SELECT p.CartID, u.fullName, p.CreateAt,
                case  
                    when p.cartStatusID = 0 then N'Chưa duyệt' 
                    when p.cartStatusID = 1 then N'Đã duyệt' 
                    when p.cartStatusID = 2 then N'Đã hủy' 
                    else N'Hoàn thành'
                end as status
                , u.address  
                FROM [Cart] AS p  
                LEFT JOIN [User] AS u 
                ON p.UserID= u.UserID 
                WHERE @cartStatusID = cartStatusID
                ";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cartStatusID", i);
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
        public Boolean UpdateStatusCart(int i , int x)
        {


            try
            {
                conn.Open();

                sql = @"
                    UPDATE [Cart] 
                    SET cartStatusID = @cartStatusID
                    WHERE CartID = @CartID";
                cmd = new SqlCommand(sql, conn);

                //B3. Gắn các Parameter và giá trị cho đối tượng Command
                cmd.Parameters.AddWithValue("@CartID", i);
                cmd.Parameters.AddWithValue("@cartStatusID",x);



                //B4. Thực thi Stored Procedure
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Cập nhật dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK);
                return false;

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
        
        public DataTable GetCartUser(int i) {
            try
            {
                conn.Open();
                sql = @"SELECT p.cartID,ps.productName,o.quantity,o.Price, p.CreateAt,
                case  
                    when p.cartStatusID = 0 then N'Chưa duyệt' 
                    when p.cartStatusID = 1 then N'Đã duyệt' 
                    when p.cartStatusID = 2 then N'Đã hủy' 
                    else N'Hoàn thành'
                end as status
                  
                FROM [Cart] AS p 
                LEFT JOIN [User] AS u 
                ON p.UserID= u.UserID 
                LEFT JOIN [Order] AS o 
                ON p.orderID= o.orderID 
                LEFT JOIN [Product] AS ps
                ON o.productID= ps.productID 
                WHERE @userId = p.userID
                ";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userId", i);
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
        public DataTable FilterCartUser(int i , int j)
        {
            try
            {
                conn.Open();
                sql = @"SELECT p.cartID,ps.productName,o.quantity,o.Price, p.CreateAt,
                case  
                    when p.cartStatusID = 0 then N'Chưa duyệt' 
                    when p.cartStatusID = 1 then N'Đã duyệt' 
                    when p.cartStatusID = 2 then N'Đã hủy' 
                    else N'Đã hủy'
                end as status
                  
                FROM [Cart] AS p 
                LEFT JOIN [User] AS u 
                ON p.UserID= u.UserID 
                LEFT JOIN [Order] AS o 
                ON p.orderID= o.orderID 
                LEFT JOIN [Product] AS ps
                ON o.productID= ps.productID 
                WHERE @cartStatusID = p.cartStatusID AND @userId = p.userID
                ";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cartStatusID", i);
                cmd.Parameters.AddWithValue("@userId", j);
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
        public Boolean InserMualai(int b, DateTime c,int d, int e)
        {
            try
            {
                conn.Open();
                sql = @"INSERT INTO [Cart] (UserID, CreateAt,cartStatusID, orderID) VALUES (@UserID, @CreateAt, @cartStatusID, @orderID)";

                cmd = new SqlCommand (sql, conn);
                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = b;

                cmd.Parameters.Add("@CreateAt", SqlDbType.DateTime).Value = c;
                cmd.Parameters.Add("@cartStatusID", SqlDbType.Int).Value = d;
                cmd.Parameters.Add("@orderID", SqlDbType.Int).Value = e;
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Thông báo", "Thêm vào giỏ hàng thành công!", MessageBoxButtons.OK);
                return true;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { conn.Close(); }
        }
        public int GetIdOrder (int i)
        {
            try
            {
                conn.Open();
                sql = @"select * from [Cart] where @cartID = cartID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cartID", i);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                DataRow dataRow = dt.Rows[0];

                return int.Parse(dataRow["orderID"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally { conn.Close(); }
        }
    }
}
