using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapChuong4
{
    public partial class form_DuyetTapTin : Form
    {
        public form_DuyetTapTin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lV_DuyetTapTin.Clear();


            var Dir = new DirectoryInfo(@"C:\Windows\");
            this.lV_DuyetTapTin.Columns.Add("NO" , 50 , HorizontalAlignment.Center);
            this.lV_DuyetTapTin.Columns.Add("Name", 150, HorizontalAlignment.Left);
            this.lV_DuyetTapTin.Columns.Add("Size" , 150 , HorizontalAlignment.Right);
            this.lV_DuyetTapTin.Columns.Add("Type", 150, HorizontalAlignment.Right);
            int i = 0;
            lV_DuyetTapTin.FullRowSelect = true;
            lV_DuyetTapTin.View = View.Details;

            //Khởi tạo đối tượng;
            ListViewItem item;
            // Duyệt qua các tập tin;
            foreach (var f in Dir.GetFiles("*.*"))
            {
                i++;
                item = new ListViewItem(i.ToString());
                item.SubItems.Add(f.Name);// new ListViewItem(f.Name);
                item.SubItems.Add(f.Length.ToString()); //= new ListViewItem(f.Length.ToString());
                item.SubItems.Add(f.Attributes.ToString()); //= new ListViewItem(f.Attributes.ToString());
                lV_DuyetTapTin.Items.Add(item);
            }
        }
    }
}
