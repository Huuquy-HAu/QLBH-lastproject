    using System.Data.SqlClient;
using System.Data;

namespace QLBH_lastproject.ConnectSql
{
    public class ProductDAO
    {
        private SqlConnection conn;
        private string sql;
        private SqlCommand cmd;
        private DataTable dt;
        public ProductDAO() { }

    }
}
