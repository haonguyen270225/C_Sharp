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
    public partial class form_TinhToan : Form
    {
        public form_TinhToan()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private float a;
        private float b;
        private float kp;

        
        private void form_TinhToan_Load(object sender, EventArgs e)
        {

        }

        private void form_TinhToan_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void form_TinhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form_kp = MessageBox.Show("Bạn có muốn thoát !", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (form_kp == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        
    }
}
