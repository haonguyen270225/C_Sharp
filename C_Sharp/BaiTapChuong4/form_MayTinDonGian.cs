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
    public partial class form_MayTinDonGian : Form
    {
        public form_MayTinDonGian()
        {
            InitializeComponent();
        }

        private void form_MayTinDonGian_Load(object sender, EventArgs e)
        {
            TB_Nhap.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            TB_Nhap.Text =  Convert.ToInt32(TB_Nhap.Text+btn.Text).ToString();
        }

        private void b_C_Click(object sender, EventArgs e)
        {
            TB_Nhap.Clear();
            c = -1;
            a = 0;
            b = 0;
            kp = 0;
        }
       

        private void b_Cong_Click(object sender, EventArgs e)
        {
            
            a = int.Parse(TB_Nhap.Text);
            c = 0;
            TB_Nhap.Clear();
        }


        private void b_Tru_Click(object sender, EventArgs e)
        {
            a = int.Parse(TB_Nhap.Text);
            c = 1;
            TB_Nhap.Clear();
        }

        private void b_Nhan_Click(object sender, EventArgs e)
        {
            a = int.Parse(TB_Nhap.Text);
            c = 2;
            TB_Nhap.Clear();
        }

        private void b_Chia_Click(object sender, EventArgs e)
        {
            a = int.Parse(TB_Nhap.Text);
            c = 3;
            TB_Nhap.Clear();
        }

        private int a = 0, b = 0, kp = 0;

        private int c = -1;

        private void b_Bang_Click(object sender, EventArgs e)
        {
            b = int.Parse(TB_Nhap.Text);
           if(c == 0)
            {
                kp = a + b;
            }
           else if(c == 1){
                kp = a - b;
            }
           else if (c == 2)
            {
                kp = a * b;
            }
            else if( c == 3)
            {
                if( b == 0)
                {
                    MessageBox.Show("Lỗi chia cho 0 !" , "Error !" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                }
                else
                {
                    kp = a / b;
                }
            }
            
            TB_Nhap.Text = kp.ToString();
            
        }


    }
}
