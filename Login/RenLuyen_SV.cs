using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_connectSQL;

namespace Login
{
    public partial class RenLuyen_SV : Form
    {
        public RenLuyen_SV()
        {
            InitializeComponent();
            load_diem();
        }

        private void RenLuyen_SV_Load(object sender, EventArgs e)
        {
            comboBox_HK.Items.Add("Học kỳ 3 Năm học 2023-2024");
            comboBox_HK.Items.Add("Học kỳ 2 Năm học 2023-2024");
        }

        private void load_diem()
        {
            using (SqlConnection conn = new SqlConnection(dll_connectSQL.DataBase_SQL.cnstr))
            {
                conn.Open();
                // Lấy dữ liệu từ bảng DG_SV
                SqlDataAdapter dA = new SqlDataAdapter("SELECT * FROM DG_SV ORDER BY MSV ASC", conn);
                DataTable dt = new DataTable();
                dA.Fill(dt);

                // Tạo bảng mới để hiển thị cột theo chiều dọc
                DataTable pivotedTable = new DataTable();
                pivotedTable.Columns.Add("Column Name");  // Cột cho tên cột
                pivotedTable.Columns.Add("Value");        // Cột cho giá trị

                // Duyệt qua từng cột trong DataTable gốc
                foreach (DataColumn col in dt.Columns)
                {
                    // Lấy từng giá trị của cột và thêm vào bảng mới
                    foreach (DataRow row in dt.Rows)
                    {
                        DataRow newRow = pivotedTable.NewRow();
                        newRow["Column Name"] = col.ColumnName;  // Thêm tên cột
                        newRow["Value"] = row[col];             // Thêm giá trị
                        pivotedTable.Rows.Add(newRow);
                    }
                }

                // Gán bảng mới vào DataGridView
                dataGridView1.DataSource = pivotedTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
        }
    }
}
