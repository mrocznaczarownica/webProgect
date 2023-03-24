using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webProgect
{
    public class DataBaseConnection
    {
        public static SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-ODCNA9G;Initial Catalog=LearnDB;Integrated Security=True");

        public static DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-ODCNA9G;Initial Catalog=LearnDB;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = selectSQL;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static DataTable ExecuteSql(string sql)
        {
            Conn.Open();
            DataTable dt = new DataTable();
            using (Conn)
            {
                SqlCommand cmd = new SqlCommand(sql, Conn);
                SqlDataReader read = cmd.ExecuteReader();

                using (read)
                {
                    dt.Load(read);
                }
            }
            Conn.Close();
            return dt;
        }
    }
}
