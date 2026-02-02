using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using Bai3_1;
using Bai3_2;
namespace BaiTapChuong3
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
         
            
            Console.WriteLine("---------------------- Bài Tập 3.1 ------------------------------");
            TaiKhoanNganHang a = new TaiKhoanNganHang("Nguyễn Văn A", 1234, 12000.0);
            TaiKhoanNganHang b = new TaiKhoanNganHang("Nguyễn Văn K", 1235, 12500.0);
            TaiKhoanNganHang.S_ThongTinDanhSachTaiKhoan();
            a.ChuyenTien(b , 5500.0);
            TaiKhoanNganHang.S_ThongTinDanhSachTaiKhoan();
            b.ChuyenTienC2(a , 5500.0);
            TaiKhoanNganHang.S_ThongTinDanhSachTaiKhoan();


            Console.WriteLine("---------------------- Bài Tập 3.2 ------------------------------");
            Nguoi f = new();
            f.NhapThongTin();
            f.XuatThongTinNguoi();

        }
    }
}
