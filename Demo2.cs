using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_Hoa_Winform
{
    public partial class Demo2 : Form 
    {
        public DialogResult Yes { get; private set; }

        public Demo2()
        {
            InitializeComponent();
        }

        #region BienToanCuc
        int solong = 0;
        #endregion
        private void Demo2_Load(object sender, EventArgs e)
        {
            ChangeSoLuong();
        }

        private void ChangeSoLuong()
        {
            solong = lstThongTin.Items.Count;
            txtSoLuong.Text = solong.ToString();
        }
        private void guna2BtnNhap_Click(object sender, EventArgs e)
        {

            if (TxtTen != null && lstThongTin != null)
            {
                if (!String.IsNullOrEmpty(TxtTen.Text))
                {
                    lstThongTin.Items.Add(TxtTen.Text);
                    ChangeSoLuong();
                    //  txt_hienthi.Text = lstBox_hienthi.Items.Count.ToString();
                    TxtTen.Clear();
                    TxtTen.Focus();
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
            }
        }
        private void btnXTTODau_Click(object sender, EventArgs e)
        {
            // int a = Convert.ToInt32(TxtTen.Text);
            if (lstThongTin.Items.Count > 0)
            {
                lstThongTin.Items.RemoveAt(0);
                ChangeSoLuong();
            }
            else
            {
                MessageBox.Show("Danh sách trống !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnXTTOCuoi_Click(object sender, EventArgs e)
        {
            if (lstThongTin.Items.Count > 0)
            {
                lstThongTin.Items.Remove(lstThongTin.Items[lstThongTin.Items.Count - 1]);
                ChangeSoLuong();
            }
            else
            {
                MessageBox.Show("Danh sách trống !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnXTTDangChon_Click(object sender, EventArgs e)
        {
            if (lstThongTin.Items.Count > 0)
            {
                /*for (int i = lstThongTin.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lstThongTin.Items.RemoveAt(lstThongTin.SelectedIndices[i]);
                }*/ // c1;
                foreach (var item in lstThongTin.SelectedItems.Cast<object>().ToList())
                {
                    lstThongTin.Items.Remove(item);
                }
                ChangeSoLuong();

            }
            else
            {
                MessageBox.Show("Danh sách trống !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn xóa tất cả thông tin trong danh sách ?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (lstThongTin.Items.Count > 0)
                {
                    lstThongTin.Items.Clear();
                    ChangeSoLuong();
                }
                else
                {
                    MessageBox.Show("Danh sách trống !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Demo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2BtnNhap_Click(sender , e);
            }
        }
    }
}
