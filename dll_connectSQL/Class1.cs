using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace dll_connectSQL
{
    public class DataBase_SQL
    {
        public string cnstr = "Server=NEKOTRANG\\DATASQL;Database=TNUT2;User Id=sa;Password=123;";
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
                        cmd.Parameters.Add("uid", SqlDbType.VarChar, 50).Value = uid;
                        cmd.Parameters.Add("pwd", SqlDbType.VarChar, 50).Value = pwd;
                        int result = (int)cmd.ExecuteScalar();
                        if (result > 0) return true;
                        else return false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối: ");
                return false;
            }
        }

    }
}
