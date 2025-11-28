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

            //DanhSachSinhVien listSinhVien = new DanhSachSinhVien(3);
            ////listSinhVien = new DanhSachSinhVien(2);
            //listSinhVien.SetDanhSachSinhVien();
            //listSinhVien.GetDanhSachSinhVien();

            Format_WriteLines.LearnWriteLine();
            Console.ReadKey();
        }
    }
}
