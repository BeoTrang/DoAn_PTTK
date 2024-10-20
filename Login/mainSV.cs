using dll_connectSQL;
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
    public partial class mainSV : Form
    {
        public mainSV()
        {
            InitializeComponent();
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
    }
}
