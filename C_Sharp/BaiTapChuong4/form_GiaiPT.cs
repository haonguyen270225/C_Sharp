using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapChuong4
{
    public partial class form_GiaiPT : Form
    {
        public form_GiaiPT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private int a2 = 0 , b2 = 0 , c2 = 0;
        private int a1 = 0, b1 = 0;


        private void b_Xoa_Click(object sender, EventArgs e)
        {
            tB_KetQua.Text = "";
            tB_NhapA.Text = "";
            tB_NhapB.Text = "";
            tB_NhapC.Text = "";

        }


        private void b_GiaiPT_Click(object sender, EventArgs e)
        {
            if (rB_PT1.Checked == true) // ax + b = 0;
            {
                a1 = int.Parse(tB_NhapA.Text);
                b1 = int.Parse(tB_NhapB.Text);
                if (a1 != 0)
                {
                    float kq = (float)-b1 / a1;
                    tB_KetQua.Text = $"Có nghiệm : {kq:2}";
                }
                else // 0x + b = 0;
                {
                    if (b1 != 0) // 0x + b = 0;
                    {
                        tB_KetQua.Text = $"{a1}X + {b1} = 0 \n Vô nghiệm !";
                    }
                    else // 0x + 0 = 0;
                    {
                        tB_KetQua.Text = $"{a1}X + {b1} = 0 \n Vô số nghiệm !";
                    }
                }
            }

            else if (rB_PT2.Checked == true)
            {
                a2 = int.Parse(tB_NhapA.Text);
                b2 = int.Parse (tB_NhapB.Text);
                c2 = int.Parse(tB_NhapC.Text);

                if(a2 == 0)
                {
                    tB_KetQua.Text = $"{a2}X^2 + {b2}X + {c2} = 0 Không phải phương trình bặc 2 !";
                }
                else
                {
                    float delta = (float)b2*b2-(float)4*a2*c2;
                    if (delta < 0 )
                    {
                        tB_KetQua.Text = $"{a2}X^2 + {b2}X + {c2} = 0 Vô nghiệm ! ";
                    }
                    else if(delta == 0)
                    {
                        float kp = (float)-b2 / a2*2;
                        tB_KetQua.Text = $"Có nghiệm kép = {kp:F}";

                    }
                    else
                    {
                        double x1 = ((double)(-b2) - Math.Sqrt(delta)) / ((double)2*a2);
                        double x2 = ((double)(-b2) +  Math.Sqrt(delta)) / ((double)2 * a2);
                        tB_KetQua.Text = $"Có hai nghiệm :\n x1 = {x1:F} - x2 = {x2:F} ";
                    }
                }
            }
        }

        private void b_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rB_PT2_CheckedChanged(object sender, EventArgs e)
        {
            rB_PT2.BackColor = Color.Red;
            rB_PT1.BackColor = Color.White; 
            
            if (rB_PT2.Checked == true)
            {
                tB_NhapC.Enabled = true;
            }


        }

        private void rB_PT1_CheckedChanged(object sender, EventArgs e)
        {
            rB_PT1.BackColor = Color.Red;
            rB_PT2.BackColor = Color.White;
            if (rB_PT2.Checked == true)
            {
                tB_NhapC.Enabled = true;
            }
        }

        private void form_GiaiPT_Load(object sender, EventArgs e)
        {
            rB_PT1.Checked = true;
            tB_NhapC.Enabled = false;
        }
    }
}
