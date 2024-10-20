using dll_connectSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class mainSV : Form
    {
        public string uid_in;
        public string hoten_in;
        public mainSV()
        {
            InitializeComponent();
            uid_in = Login_scr.uid;
            LB_MSV.Text = uid_in;
            using (SqlConnection conn = new SqlConnection(DataBase_SQL.cnstr))
            {
                string query = "SELECT Hoten FROM ThongTin_SV WHERE MSV = @uid";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Gán tham số cho câu lệnh SQL
                    cmd.Parameters.Add("uid", SqlDbType.VarChar, 20).Value = uid_in;

                    // Sử dụng ExecuteReader để thực thi câu lệnh và lấy dữ liệu
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Kiểm tra nếu có bản ghi nào được trả về
                        {
                            string hoten_in = reader["Hoten"].ToString();
                            LB_HVT.Text = hoten_in; // Gán giá trị cho label
                        }
                        else
                        {
                            Console.WriteLine("Không tìm thấy người dùng.");
                        }
                    }
                }
            }

        }
    

        private void ChucNang_RL_Click(object sender, EventArgs e)
        {
            RenLuyen_SV renLuyen_SV = new RenLuyen_SV();
            renLuyen_SV.ShowDialog();
        }

        private void ChucNang_RL_MouseEnter(object sender, EventArgs e)
        {
            ChucNang_RL.Cursor = Cursors.Hand;
        }

        private void ChucNang_RL_MouseLeave(object sender, EventArgs e)
        {
            ChucNang_RL.Cursor = Cursors.Default;
        }

        private void BT_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LB_ChangePWD_Click(object sender, EventArgs e)
        {
            ChangPWD changPWD = new ChangPWD();
            changPWD.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LB_MSV_Click(object sender, EventArgs e)
        {

        }

        private void LB_HVT_Click(object sender, EventArgs e)
        {

        }
    }
}
