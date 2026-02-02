using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapChuong4
{
    public partial class form_DangNhap : Form
    {
        private string tenDangNhap = "student";
        private string matKhau = "123";
        public form_DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(txt_MatKhau.Text == matKhau && tenDangNhap == tenDangNhap)
            {
                MessageBox.Show("Đăng nhập thành công !" , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Đăng nhập thất bại ! ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void form_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form_kp = MessageBox.Show("Bạn có muốn thoát !", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (form_kp == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void form_DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
