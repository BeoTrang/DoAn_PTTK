using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace dll_connectSQL
{
    public class DataBase_SQL
    {
        public static string cnstr = "Server=DESKTOP-VICTOR1\\SQLEXPRESS;Database=DRL;User Id=sa;Password=1234;";
        public bool Login(string uid, string pwd)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    string query = "SELECT COUNT(*) FROM TaiKhoan WHERE UID = @uid AND PWD = @pwd";
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("uid", SqlDbType.VarChar, 20).Value = uid;
                        cmd.Parameters.Add("pwd", SqlDbType.VarChar, 20).Value = pwd;
                        int result = (int)cmd.ExecuteScalar();
                        if (result > 0) return true;
                        else return false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối: " + e);
                return false;
            }
        }

        public static DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(cnstr))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
            }

            return dt;
        }
    }
}
