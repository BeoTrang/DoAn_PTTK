using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class ChangPWD : Form
    {
        public ChangPWD()
        {
            InitializeComponent();
        }

        private void BT_changePWD_Click(object sender, EventArgs e)
        {
            if(TB_oldPWD.Text == "" ||TB_newPWD_1.Text == "" || TB_newPWD_2.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Đổi mật khẩu thành công!");
            this.Close();
        }
    }
}
