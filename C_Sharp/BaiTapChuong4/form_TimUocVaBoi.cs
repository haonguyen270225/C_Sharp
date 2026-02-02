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
    public partial class form_TimUocVaBoi : Form
    {

        private int Tim_USCLN(int a , int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if(a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }

        private int Tim_BSCNN(int a , int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            return a * b / Tim_USCLN(a, b);
        }

        public form_TimUocVaBoi()
        {
            InitializeComponent();
        }

        private void form_TimUocVaBoi_Load(object sender, EventArgs e)
        {   
            rB_USCLN.Checked = true;
            a = 0;
            b = 0;
            kq = 0;
        }

        private void rB_USCLN_CheckedChanged(object sender, EventArgs e)
        {
            if(rB_USCLN.Checked == true)
            {
                rB_USCLN.BackColor = Color.Red;
                rB_BSCNN.BackColor = Color.White;
            }
        }

        private void rB_BSCNN_CheckedChanged(object sender, EventArgs e)
        {
            rB_BSCNN.BackColor = Color.Red;
            rB_USCLN.BackColor = Color.White;
            
        }

        private void b_BoQua_Click(object sender, EventArgs e)
        {
            tB_KetQua.Text = "";
            tB_NhapA.Text = "";
            tB_NhapB.Text = "";
        }

        private void b_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int a;
        private int b;
        private int kq;
        private void b_Tim_Click(object sender, EventArgs e)
        {

            a = int.Parse(tB_NhapA.Text);
            b = int.Parse(tB_NhapB.Text);
            if (rB_USCLN.Checked == true)
            {
                
                if (a == 0 && b == 0)
                {
                    tB_KetQua.Text = $"Không có USCLN !";
                }
                else 
                {
                    kq = Tim_USCLN(a, b);
                    tB_KetQua.Text = $"Kết quả USCLN : {kq}";
                }
            }
            else if(rB_BSCNN.Checked == true)
            {
               if(a == 0 || b == 0)
                {
                    tB_KetQua.Text = $"Không có BSCNN !";
                }
               else
                {
                    kq = Tim_BSCNN(a, b);
                    tB_KetQua.Text = $"Kết quả BSCNN : {kq}";
                }
            }
        }

        private void tB_NhapA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tB = (TextBox)sender;
            if (e.KeyChar == '-' && tB.SelectionStart == 0 && !tB.Text.Contains("-"))
            {
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

                MessageBox.Show("Vui lòng nhập số nguyên !", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
