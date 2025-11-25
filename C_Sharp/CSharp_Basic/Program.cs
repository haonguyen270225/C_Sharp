using Variable;
using CSharp_Basic.OOP;
using System.Text;
namespace CSharp_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.UTF8;
            //NhapDuLieu a = new NhapDuLieu();
            //a.DemoNhapDuLieu();
            //KhaiBao_Bien b = new KhaiBao_Bien();
            //b.KhaiBaoBien();
            //SinhVien sv = new SinhVien();
            //sv.SetSinhVien();
            //sv.GetSinhVien();


            DanhSachSinhVien listSinhVien = null;
            listSinhVien = new DanhSachSinhVien(2);
            listSinhVien.SetDanhSachSinhVien();
            listSinhVien.GetSinhVien();
        }
    }
}
