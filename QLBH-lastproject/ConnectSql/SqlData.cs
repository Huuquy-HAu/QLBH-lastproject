﻿using System;
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
    }
}