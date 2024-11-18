namespace Control_Pic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pat = Application.StartupPath + "\\demo_control_winform_pic\\";
        int so = 0;
        Random rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {

            so = rand.Next(1, 6);
            if (so == 4)
            {
                picAnh.Image = Image.FromFile(pat + so + ".png");
                lblTenAnh.Text = so.ToString() + ".png";
            }
            else
            {
                picAnh.Image = Image.FromFile(pat + so + ".jpg");
                lblTenAnh.Text = so.ToString() + ".jpg";
            }
            
        }

    }
}
