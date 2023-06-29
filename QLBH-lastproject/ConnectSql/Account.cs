using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_lastproject.ConnectSql
{
    public class Account
    {
        
        public static Account instance;

        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return Account.instance; }
            private set { instance = value; }
       }
        public int userID { get; set; }
        public string userName { get; set; }

        public string password { get; set; }


        public int roleID { get; set; }


        public Account(DataRow row)
        {
            userID = (int)row["userID"];
            userName = row["userName"].ToString();
            password = row["password"].ToString();
            roleID = (int)row["roleID"];
        }

        public Account() { }



        public static List<Account> GetAllAccounts()
        {
            List<Account> accountList = new List<Account>();

            string query = "SELECT [userID], [userName], [password], [roleID] FROM [User]";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Account account = new Account();
                account.userID = (int)row["userID"];
                account.userName = row["userName"].ToString();
                account.password = row["password"].ToString();
                account.roleID = (int)row["roleID"];

                accountList.Add(account);
            }

            return accountList;
        }

            public List<string> GetAllRoles()
            {
                List<string> roles = new List<string>();

                string query = "SELECT [roleName] FROM [Role]";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                foreach (DataRow row in data.Rows)
                {
                    string roleName = row["RoleName"].ToString();
                    roles.Add(roleName);
                }

                return roles;
            }

            public void AddAccount(string userName, string password, int roleID)
            {
                string query = "INSERT INTO [User] ( [userName], [password], [roleID]) VALUES ( @userName, @password, @roleID)";

            SqlParameter[] parameters =
            {
                    new SqlParameter("@userName", userName),
                    new SqlParameter("@password", password),
                    new SqlParameter("@roleID", roleID)
            };

            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

            public void UpdateAccount(string password, int roleID, int userID)
            {
                string query = "UPDATE [User] SET [password] = @password, [roleID] = @roleID WHERE userID = @userID";

                SqlParameter[] parameters =
                {
                    new SqlParameter("@password", password),
                    new SqlParameter("@roleID", roleID),
                    new SqlParameter("@userID", userID)
                };

                DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }


    }
}
