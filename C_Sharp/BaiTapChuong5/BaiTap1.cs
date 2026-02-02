using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BaiTapChuong5
{

    public partial class BaiTap1 : Form
    {
        public BaiTap1()
        {
            InitializeComponent();
        }

        // Khai bao Connection;
        public SqlConnection ketnoi;
        public string chuoiKN = @"Data Source=TUFGAMINGF15; Initial Catalog=KetQuaHocTap; Integrated Security=True;";

        //public DataGirdView dataGirdView;
        //static  public void  LoadData()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("MaMon");
        //    dt.Columns.Add("TenMon");
        //    dt.Columns.Add("SoTinChi");


        //    DataRow dr = dt.NewRow();
        //    dr["MaMon"] = "MH001";
        //    dr["TenMon"] = "Lập trình câb bản";
        //    dr["SoTinChi"] = 5;
        //    dt.Rows.Add(dr);

        //    DGW_ThongTinMonHoc.Rows.Add(dt);
        //}
        //private void form_MonHoc_Load(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("STT");
        //    dt.Columns.Add("MaMon");
        //    dt.Columns.Add("TenMon");
        //    dt.Columns.Add("SoTinChi");

        //    DataRow dr = dt.NewRow();
        //    dr["STT"] = 1;
        //    dr["MaMon"] = "LTCB";
        //    dr["TenMon"] = "Lập trình căn bản ";
        //    dr["SoTinChi"] = 1;
        //    dt.Rows.Add(dr);

        //    dr = dt.NewRow();
        //    dr["STT"] = 2;
        //    dr["MaMon"] = "LTC#";
        //    dr["TenMon"] = "Lập trình C#";
        //    dr["SoTinChi"] = 3;
        //    dt.Rows.Add(dr);
        //    DGV_DuLieu.DataSource = dt;
        //}
        private void BaiTap1_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiKN);
            try
            {
                ketnoi.Open();
                if (ketnoi.State == ConnectionState.Open)
                {
                    MessageBox.Show("Kết nối thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.None);

                    SqlCommand loadMonHoc = ketnoi.CreateCommand();
                    loadMonHoc.CommandText = @"SELECT [MaMH]
                                                     ,[TenMH]
                                                     ,[SoTC]                  
                                                FROM[KetQuaHocTap].[dbo].[MonHoc]";

                    SqlDataReader dtR = loadMonHoc.ExecuteReader();
                    if (dtR.HasRows)
                    {
                        DataTable monHoc = new DataTable();
                        monHoc.Columns.Add("MaMon");
                        monHoc.Columns.Add("TenMon");
                        monHoc.Columns.Add("SoTC");

                        while (dtR.Read())
                        {
                            DataRow dr = monHoc.NewRow();
                            dr["MaMon"] = dtR.GetValue(0).ToString();
                            dr["TenMon"] = dtR.GetValue(1).ToString();
                            dr["SoTC"] = dtR.GetInt32(2);
                            monHoc.Rows.Add(dr);
                        }
                        DGW_ThongTinMonHoc.DataSource = monHoc;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kết nối thất bại !" + ex.Message.ToString());
            }
            finally
            {
                if(ketnoi.State == ConnectionState.Open)
                    ketnoi.Close();
            }
        }



        private void DGW_ThongTinMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_MaMon.Text = DGW_ThongTinMonHoc.CurrentRow.Cells["MaMon"].Value.ToString();
            TB_TenMon.Text = DGW_ThongTinMonHoc.CurrentRow.Cells["TenMon"].Value.ToString();
            TB_SoTiet.Text = DGW_ThongTinMonHoc.CurrentRow.Cells["SoTinChi"].Value.ToString();
        }

        private void LoadingData()
        {
            try
            {
               
                if (ketnoi.State == ConnectionState.Open)
                {
                    MessageBox.Show("Gọi hàm Loading Data ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.None);

                    SqlCommand loadMonHoc = ketnoi.CreateCommand();
                    loadMonHoc.CommandText = @"SELECT [MaMH]
                                                     ,[TenMH]
                                                     ,[SoTC]                  
                                                FROM[KetQuaHocTap].[dbo].[MonHoc]";

                    SqlDataReader dtR = loadMonHoc.ExecuteReader();
                    if (dtR.HasRows)
                    {
                        DataTable monHoc = new DataTable();
                        monHoc.Columns.Add("MaMon");
                        monHoc.Columns.Add("TenMon");
                        monHoc.Columns.Add("SoTC");

                        while (dtR.Read())
                        {
                            DataRow dr = monHoc.NewRow();
                            dr["MaMon"] = dtR.GetValue(0).ToString();
                            dr["TenMon"] = dtR.GetValue(1).ToString();
                            dr["SoTC"] = dtR.GetInt32(2);
                            monHoc.Rows.Add(dr);
                        }
                        DGW_ThongTinMonHoc.DataSource = monHoc;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Kết nối thất bại !" + ex.Message.ToString());
            }

            finally
            {
                if (ketnoi.State == ConnectionState.Open)
                    ketnoi.Close();
            }
        }


        private void b_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Open();
                if (ketnoi.State == ConnectionState.Open)
                { 
                    MessageBox.Show("Kết nối thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.None);

                    string maMon = TB_MaMon.Text.Trim().ToString();
                    string tenMon = TB_TenMon.Text.Trim().ToString();
                    int soTC = Convert.ToInt32(TB_SoTiet.Text.Trim());


                    SqlCommand insertMonHoc = ketnoi.CreateCommand();
                    insertMonHoc.CommandText = @"INSERT INTO [dbo].[MonHoc]
                                                ([MaMH] , [TenMH] , [SoTC]) 
                                                VALUES(@maMon , @tenMon , @soTC)";
                    insertMonHoc.Parameters.Clear();

                    //   SqlParameter parameterMaMon = new SqlParameter();
                    //   parameterMaMon.ParameterName = "@maMon";
                    //   parameterMaMon.SqlDbType = SqlDbType.NVarChar;
                    //   //parameterMaMon.Size = 10;
                    //   parameterMaMon.Value = maMon;



                    //   SqlParameter parameterTenMon = new SqlParameter();
                    //   parameterMaMon.ParameterName = "@tenMon";
                    //   parameterTenMon.SqlDbType = SqlDbType.NVarChar;
                    ////   parameterTenMon.Size = 50;
                    //   parameterTenMon.Value = tenMon;

                    //   SqlParameter parameterSoTC = new SqlParameter();
                    //   parameterSoTC.ParameterName = "@soTC";
                    //   parameterSoTC.SqlDbType = SqlDbType.Int;
                    //   parameterSoTC.Value = soTC;

                    //   insertMonHoc.Parameters.Add(parameterMaMon);
                    //   insertMonHoc.Parameters.Add(parameterTenMon);
                    //   insertMonHoc.Parameters.Add(parameterSoTC);

                    insertMonHoc.Parameters.AddWithValue("@maMon" , maMon);
                    insertMonHoc.Parameters.AddWithValue("@tenMon", tenMon);
                    insertMonHoc.Parameters.AddWithValue("@soTC", soTC);
                    int kq = (int)insertMonHoc.ExecuteNonQuery();
                    MessageBox.Show($"{kq}");
                     LoadingData();
                    //BaiTap1_Load(sender, e);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kết nối thất bại !" + ex.Message.ToString());
            }
            finally
            {
               
                if (ketnoi.State == ConnectionState.Open)
                {
                    ketnoi.Close();
                }
            }
        }

        //DELETE
        //FROM[dbo].[MonHoc]
        //WHERE MonHoc.MaMH = 'MH015';
        private void b_Xoa_Click(object sender, EventArgs e)
        {
           if(DGW_ThongTinMonHoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dòng để sóa ! ", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                    ketnoi.Open();
                    try
                    {
                        if (ketnoi.State == ConnectionState.Open)
                        {
                            int cnt = 0;
                            foreach (DataGridViewRow row in DGW_ThongTinMonHoc.SelectedRows)
                            {
                                //MessageBox.Show($"{row.Cells["maMon"].Value.ToString()} \t");

                                string maMon = row.Cells[0].Value.ToString();
                                SqlCommand sqlCommand = ketnoi.CreateCommand();

                                sqlCommand.CommandText = @"DELETE
                                                        FROM[dbo].[MonHoc]
                                                        WHERE MonHoc.MaMH = @maMon;";

                                sqlCommand.Parameters.AddWithValue("@maMon", maMon);
                                sqlCommand.ExecuteNonQuery();
                                cnt++;
                            }
                            MessageBox.Show($"Số dòng đã sóa là : {cnt}");
                        LoadingData();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể kết nối ! {ex.Message}");
                    }

                    finally
                    {
                        if(ketnoi.State == ConnectionState.Open)
                        {
                            ketnoi.Close();
                        }
                    }
                    
                    
                }
            }

        private void b_Sua_Click(object sender, EventArgs e)
        {

            try
            {
                ketnoi.Open();
                if (ketnoi.State == ConnectionState.Open)
                {
                    if (DGW_ThongTinMonHoc.SelectedRows.Count != 1)
                    {
                        MessageBox.Show("Chỉ được chỉnh sửa một dòng !", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string maMon = TB_MaMon.Text.Trim().ToString();
                        string tenMon = TB_TenMon.Text.Trim().ToString();
                        int soTC = Convert.ToInt32(TB_SoTiet.Text);

                        SqlCommand sqlCommand = ketnoi.CreateCommand();
                        sqlCommand.CommandText = @"UPDATE MonHoc
                                            SET 
                                            MonHoc.TenMH = @tenMon,
                                            MonHoc.SoTC = @soTC
                                            WHERE MonHoc.MaMH = @maMon;";

                        sqlCommand.Parameters.AddWithValue("@tenMon", tenMon);
                        sqlCommand.Parameters.AddWithValue("@soTC", soTC);
                        sqlCommand.Parameters.AddWithValue("@maMon", maMon);

                        sqlCommand.ExecuteNonQuery();
                        LoadingData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối ! {ex.Message}");
            }

            finally
            {
                if (ketnoi.State == ConnectionState.Open)
                {
                    ketnoi.Close();
                }
            }
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
