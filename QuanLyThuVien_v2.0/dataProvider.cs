using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien_v2._0
{
    internal class dataProvider
    {
        static public string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Library2;Integrated Security=True";
        static public SqlConnection conn;

        static public DataTable LoadDatabase(string querry)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(connStr);
            SqlCommand sqlcmd = new SqlCommand(querry, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcmd);
            adapter.Fill(dt);
            return dt;
        }
        static public DataTable LoadDatabase(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            conn = new SqlConnection(connStr);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        static public int Change(string querry)
        {
            conn = new SqlConnection(connStr);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand sqlCommand = new SqlCommand(querry, conn);
            int res = sqlCommand.ExecuteNonQuery();
            conn.Close();
            return res;
        }
    }
}
