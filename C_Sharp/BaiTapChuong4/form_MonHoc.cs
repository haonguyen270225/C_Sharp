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

namespace BaiTapChuong4
{
   public partial class form_MonHoc : Form
    {
        public form_MonHoc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form_MonHoc_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("MaMon");
            dt.Columns.Add("TenMon");
            dt.Columns.Add("SoTinChi");

            DataRow dr = dt.NewRow();
            dr["STT"] = 1;
            dr["MaMon"] = "LTCB";
            dr["TenMon"] = "Lập trình căn bản ";
            dr["SoTinChi"] = 1;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["STT"] = 2;
            dr["MaMon"] = "LTC#";
            dr["TenMon"] = "Lập trình C#";
            dr["SoTinChi"] = 3;
            dt.Rows.Add(dr);
            DGW_DuLieu.DataSource = dt;

        }
        private void DGV_DuLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_MaMon.Text = DGW_DuLieu.CurrentRow.Cells["MaMon"].Value.ToString();
            TB_TenMon.Text = DGW_DuLieu.CurrentRow.Cells["TenMon"].Value.ToString();
            TB_SoTinChi.Text = DGW_DuLieu.CurrentRow.Cells["SoTinChi"].Value.ToString();
        }
    }
}
