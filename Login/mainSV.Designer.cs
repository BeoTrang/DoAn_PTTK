namespace Login
{
    partial class mainSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_MSV = new System.Windows.Forms.Label();
            this.LB_HVT = new System.Windows.Forms.Label();
            this.BT_Logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChucNang_12 = new System.Windows.Forms.Label();
            this.ChucNang_11 = new System.Windows.Forms.Label();
            this.ChucNang_10 = new System.Windows.Forms.Label();
            this.ChucNang_9 = new System.Windows.Forms.Label();
            this.ChucNang_8 = new System.Windows.Forms.Label();
            this.ChucNang_7 = new System.Windows.Forms.Label();
            this.ChucNang_6 = new System.Windows.Forms.Label();
            this.ChucNang_5 = new System.Windows.Forms.Label();
            this.ChucNang_RL = new System.Windows.Forms.Label();
            this.ChucNang_3 = new System.Windows.Forms.Label();
            this.ChucNang_2 = new System.Windows.Forms.Label();
            this.ChucNang_1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_ChangePWD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            // 
            // LB_MSV
            // 
            this.LB_MSV.AutoSize = true;
            this.LB_MSV.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MSV.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LB_MSV.Location = new System.Drawing.Point(112, 21);
            this.LB_MSV.Name = "LB_MSV";
            this.LB_MSV.Size = new System.Drawing.Size(166, 23);
            this.LB_MSV.TabIndex = 2;
            this.LB_MSV.Text = "Mã sinh viên ở đây";
            // 
            // LB_HVT
            // 
            this.LB_HVT.AutoSize = true;
            this.LB_HVT.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_HVT.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LB_HVT.Location = new System.Drawing.Point(112, 54);
            this.LB_HVT.Name = "LB_HVT";
            this.LB_HVT.Size = new System.Drawing.Size(140, 23);
            this.LB_HVT.TabIndex = 3;
            this.LB_HVT.Text = "Họ và tên ở đây";
            // 
            // BT_Logout
            // 
            this.BT_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BT_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Logout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Logout.ForeColor = System.Drawing.Color.White;
            this.BT_Logout.Location = new System.Drawing.Point(6, 92);
            this.BT_Logout.Name = "BT_Logout";
            this.BT_Logout.Size = new System.Drawing.Size(325, 32);
            this.BT_Logout.TabIndex = 4;
            this.BT_Logout.Text = "Đăng xuất";
            this.BT_Logout.UseVisualStyleBackColor = false;
            this.BT_Logout.Click += new System.EventHandler(this.BT_Logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LB_ChangePWD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BT_Logout);
            this.panel1.Controls.Add(this.LB_MSV);
            this.panel1.Controls.Add(this.LB_HVT);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 166);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ChucNang_12);
            this.panel2.Controls.Add(this.ChucNang_11);
            this.panel2.Controls.Add(this.ChucNang_10);
            this.panel2.Controls.Add(this.ChucNang_9);
            this.panel2.Controls.Add(this.ChucNang_8);
            this.panel2.Controls.Add(this.ChucNang_7);
            this.panel2.Controls.Add(this.ChucNang_6);
            this.panel2.Controls.Add(this.ChucNang_5);
            this.panel2.Controls.Add(this.ChucNang_RL);
            this.panel2.Controls.Add(this.ChucNang_3);
            this.panel2.Controls.Add(this.ChucNang_2);
            this.panel2.Controls.Add(this.ChucNang_1);
            this.panel2.Location = new System.Drawing.Point(12, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 387);
            this.panel2.TabIndex = 7;
            // 
            // ChucNang_12
            // 
            this.ChucNang_12.AutoSize = true;
            this.ChucNang_12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_12.Location = new System.Drawing.Point(3, 343);
            this.ChucNang_12.Name = "ChucNang_12";
            this.ChucNang_12.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_12.Size = new System.Drawing.Size(159, 31);
            this.ChucNang_12.TabIndex = 11;
            this.ChucNang_12.Text = "> Khảo sát đánh giá";
            // 
            // ChucNang_11
            // 
            this.ChucNang_11.AutoSize = true;
            this.ChucNang_11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_11.Location = new System.Drawing.Point(3, 312);
            this.ChucNang_11.Name = "ChucNang_11";
            this.ChucNang_11.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_11.Size = new System.Drawing.Size(102, 31);
            this.ChucNang_11.TabIndex = 10;
            this.ChucNang_11.Text = "> Xem điểm";
            // 
            // ChucNang_10
            // 
            this.ChucNang_10.AutoSize = true;
            this.ChucNang_10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_10.Location = new System.Drawing.Point(3, 281);
            this.ChucNang_10.Name = "ChucNang_10";
            this.ChucNang_10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_10.Size = new System.Drawing.Size(115, 31);
            this.ChucNang_10.TabIndex = 9;
            this.ChucNang_10.Text = "> Xem lịch thi";
            // 
            // ChucNang_9
            // 
            this.ChucNang_9.AutoSize = true;
            this.ChucNang_9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_9.Location = new System.Drawing.Point(3, 250);
            this.ChucNang_9.Name = "ChucNang_9";
            this.ChucNang_9.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_9.Size = new System.Drawing.Size(227, 31);
            this.ChucNang_9.TabIndex = 8;
            this.ChucNang_9.Text = "> Xem thời khoá biểu học kỳ";
            // 
            // ChucNang_8
            // 
            this.ChucNang_8.AutoSize = true;
            this.ChucNang_8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_8.Location = new System.Drawing.Point(3, 219);
            this.ChucNang_8.Name = "ChucNang_8";
            this.ChucNang_8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_8.Size = new System.Drawing.Size(207, 31);
            this.ChucNang_8.TabIndex = 7;
            this.ChucNang_8.Text = "> Xem thời khoá biểu tuần";
            // 
            // ChucNang_7
            // 
            this.ChucNang_7.AutoSize = true;
            this.ChucNang_7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_7.Location = new System.Drawing.Point(3, 188);
            this.ChucNang_7.Name = "ChucNang_7";
            this.ChucNang_7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_7.Size = new System.Drawing.Size(227, 31);
            this.ChucNang_7.TabIndex = 6;
            this.ChucNang_7.Text = "> Đăng ký môn nguyện vọng";
            // 
            // ChucNang_6
            // 
            this.ChucNang_6.AutoSize = true;
            this.ChucNang_6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_6.Location = new System.Drawing.Point(3, 157);
            this.ChucNang_6.Name = "ChucNang_6";
            this.ChucNang_6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_6.Size = new System.Drawing.Size(211, 31);
            this.ChucNang_6.TabIndex = 5;
            this.ChucNang_6.Text = "> Rút môn học đã đăng ký";
            // 
            // ChucNang_5
            // 
            this.ChucNang_5.AutoSize = true;
            this.ChucNang_5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_5.Location = new System.Drawing.Point(3, 126);
            this.ChucNang_5.Name = "ChucNang_5";
            this.ChucNang_5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_5.Size = new System.Drawing.Size(160, 31);
            this.ChucNang_5.TabIndex = 4;
            this.ChucNang_5.Text = "> Đăng ký môn học";
            // 
            // ChucNang_RL
            // 
            this.ChucNang_RL.AutoSize = true;
            this.ChucNang_RL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_RL.Location = new System.Drawing.Point(3, 95);
            this.ChucNang_RL.Name = "ChucNang_RL";
            this.ChucNang_RL.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_RL.Size = new System.Drawing.Size(223, 31);
            this.ChucNang_RL.TabIndex = 3;
            this.ChucNang_RL.Text = "> Đánh giá kết quả rèn luyện";
            this.ChucNang_RL.Click += new System.EventHandler(this.ChucNang_RL_Click);
            this.ChucNang_RL.MouseEnter += new System.EventHandler(this.ChucNang_RL_MouseEnter);
            this.ChucNang_RL.MouseLeave += new System.EventHandler(this.ChucNang_RL_MouseLeave);
            // 
            // ChucNang_3
            // 
            this.ChucNang_3.AutoSize = true;
            this.ChucNang_3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_3.Location = new System.Drawing.Point(3, 64);
            this.ChucNang_3.Name = "ChucNang_3";
            this.ChucNang_3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_3.Size = new System.Drawing.Size(209, 31);
            this.ChucNang_3.TabIndex = 2;
            this.ChucNang_3.Text = "> Xem môn học tiên quyết";
            // 
            // ChucNang_2
            // 
            this.ChucNang_2.AutoSize = true;
            this.ChucNang_2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_2.Location = new System.Drawing.Point(3, 33);
            this.ChucNang_2.Name = "ChucNang_2";
            this.ChucNang_2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_2.Size = new System.Drawing.Size(223, 31);
            this.ChucNang_2.TabIndex = 1;
            this.ChucNang_2.Text = "> Xem chương trình đào tạo";
            // 
            // ChucNang_1
            // 
            this.ChucNang_1.AutoSize = true;
            this.ChucNang_1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ChucNang_1.Location = new System.Drawing.Point(3, 2);
            this.ChucNang_1.Name = "ChucNang_1";
            this.ChucNang_1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ChucNang_1.Size = new System.Drawing.Size(221, 31);
            this.ChucNang_1.TabIndex = 0;
            this.ChucNang_1.Text = "> Thông báo từ ban quản trị";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 46);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "TÍNH NĂNG";
            // 
            // LB_ChangePWD
            // 
            this.LB_ChangePWD.AutoSize = true;
            this.LB_ChangePWD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ChangePWD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LB_ChangePWD.Location = new System.Drawing.Point(216, 127);
            this.LB_ChangePWD.Name = "LB_ChangePWD";
            this.LB_ChangePWD.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LB_ChangePWD.Size = new System.Drawing.Size(115, 26);
            this.LB_ChangePWD.TabIndex = 9;
            this.LB_ChangePWD.Text = "Đổi mật khẩu";
            this.LB_ChangePWD.Click += new System.EventHandler(this.LB_ChangePWD_Click);
            // 
            // mainSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 647);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "mainSV";
            this.Text = "Trang chủ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_MSV;
        private System.Windows.Forms.Label LB_HVT;
        private System.Windows.Forms.Button BT_Logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ChucNang_1;
        private System.Windows.Forms.Label ChucNang_12;
        private System.Windows.Forms.Label ChucNang_11;
        private System.Windows.Forms.Label ChucNang_10;
        private System.Windows.Forms.Label ChucNang_9;
        private System.Windows.Forms.Label ChucNang_8;
        private System.Windows.Forms.Label ChucNang_7;
        private System.Windows.Forms.Label ChucNang_6;
        private System.Windows.Forms.Label ChucNang_5;
        private System.Windows.Forms.Label ChucNang_RL;
        private System.Windows.Forms.Label ChucNang_3;
        private System.Windows.Forms.Label ChucNang_2;
        private System.Windows.Forms.Label LB_ChangePWD;
    }
}