using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using dll_connectSQL;

namespace Login
{
    public partial class Login : Form
    {
        public bool stop = false;
        public int dem_login = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            if (TB_pwd.Text == "" || TB_uid.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string uid = TB_uid.Text;
            string pwd = TB_pwd.Text;

            DataBase_SQL db = new DataBase_SQL();
            bool DangNhap = db.Login(uid, pwd);
            if(DangNhap == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                mainSV mainSV = new mainSV();
                this.Hide();
                mainSV.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dem_login++; 
                return;
            }
            //Form_Captcha captcha = new Form_Captcha();
            //captcha.FormClosing += new FormClosingEventHandler(Captcha_FormClosing);
            //captcha.ShowDialog();
            //if (stop == true)
            //{
            //    MessageBox.Show("Bạn không điền Captcha nên không thể đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //} 
        }
        private void Captcha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Captcha captcha = sender as Form_Captcha;
            if (e.CloseReason == CloseReason.UserClosing && !captcha.IsProgrammaticClose)
            {
                stop = true;
            }
        }

        //private void Login_Load(object sender, EventArgs e)
        //{
        //    TB_pwd.PasswordChar = '*';
        //    string action = this.Request["action"];
        //    switch (action)
        //    {
        //        case "login":
        //            login();
        //            break;
        //        case "captcha":
        //            Tao_Anh_Captcha();
        //            break;
        //        default:
        //            this.Response.Write("{\"ok\": 0, \"msg\": \"Hành động không hợp lệ.\"}");
        //            break;
        //    }
        //}
        //dll_connectSQL.db_sqlserver get_db()
        //{
        //    dll_connectSQL.db_sqlserver db = new dll_connectSQL.db_sqlserver();
        //    db.cnstr = "Server=NEKOTRANG\\DATASQL;Database=Login_Data;User Id=sa;Password=123;";
        //    return db;
        //}

        private void Login_Load(object sender, EventArgs e)
        {
            TB_pwd.PasswordChar = '*';
        }
    }
}
