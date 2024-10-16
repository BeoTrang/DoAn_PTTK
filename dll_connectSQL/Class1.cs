using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace dll_connectSQL
{
    public class db_sqlserver
    {
        public string cnstr;
        public string login(string uid, string pwd)
        {
            string json = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(cnstr))
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_API";
                        cmd.Parameters.Add("uid", SqlDbType.VarChar, 50).Value = uid;
                        cmd.Parameters.Add("pwd", SqlDbType.VarChar, 50).Value = pwd;
                        cmd.Parameters.Add("@action", SqlDbType.VarChar, 50).Value = "login";
                        object result = cmd.ExecuteScalar();
                        json = (string)result;
                    }
                }
            }
            catch
            {
                json = "{\"ok\":0,\"msg\":\"Không kết nối được\"}";
            }
            return json;
        }

    }
}
