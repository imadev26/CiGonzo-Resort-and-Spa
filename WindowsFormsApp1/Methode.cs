using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Methode
    {
        public string pub = "Server=tcp:dargonzo.database.windows.net,1433;Initial Catalog=dargonzo;Persist Security Info=False;User ID=dargonzo;Password=Gonzo2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        public static SqlConnection ConnectSqlserver()
        {
            SqlConnection conn = new SqlConnection("Server=tcp:dargonzo.database.windows.net,1433;Initial Catalog=dargonzo;Persist Security Info=False;User ID=dargonzo;Password=Gonzo2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            conn.Open();
            return conn;
        }
        public static void DisconnectSqlserver()
        {
            SqlConnection conn = new SqlConnection("Server=tcp:dargonzo.database.windows.net,1433;Initial Catalog=dargonzo;Persist Security Info=False;User ID=dargonzo;Password=Gonzo2022;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            conn.Close();
        }
        public static SqlDataReader select(string query)
        {
            SqlConnection cnx = ConnectSqlserver();
            SqlCommand cmd = new SqlCommand(query, cnx);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }
        public static int update(string query)
        {
            SqlConnection cnx = ConnectSqlserver();
            SqlCommand cmd = new SqlCommand(query, cnx);
            int rs = cmd.ExecuteNonQuery();
            return rs;
        }
    }
}
