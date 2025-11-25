using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basic.OOP
{
    internal class SinhVien
    {
        private string HoVaTen {  get; set; }
        private string DiaChi {  get; set; }

        private int NamSinh {  get; set; }
        private string MaSinhVien {  get; set; }

        public SinhVien()
        {
            HoVaTen = "" ;
            DiaChi = "";
            NamSinh = 0;
            MaSinhVien = "";
        }
        public SinhVien(string hoVaTen, string diaChi, int namSinh, string maSinhVien)
        {
            if(hoVaTen.Length < 5)
            {
                Console.WriteLine("Tên không hợp lệ !");
            }
            else
            {
                this.HoVaTen = hoVaTen;
            }
            if(diaChi.Length < 5)
            {
                Console.WriteLine("Địa chỉ không hợp lệ !");
            }
            else
            {
                this.DiaChi = diaChi;
            }
            if(namSinh > 2017)
            {
                Console.WriteLine("Năm sinh không hợp lệ !");
            }
            else
            {
                NamSinh = namSinh;
            }
            if(maSinhVien.Length != 5)
            {
                Console.WriteLine("Mã sinh viên không hơp lệ !");
            }
            else
            {
                this.MaSinhVien = maSinhVien;
            }
        }

       ~SinhVien() { }

        public void SetSinhVien(out SinhVien  sv)
        {
            SinhVien tmp = null;
            Console.WriteLine("\t Thông tin sinh viên : ");
            // Nhập họ và tên
            Console.Write("Họ và tên sinh viên :");
            tmp.HoVaTen = Console.ReadLine();
            do
            {
                if (tmp.HoVaTen.Length < 5)
                {
                    Console.WriteLine("Họ và tên không hợp lệ (Họ và tên >= 5 ký tự) !");
                    Console.Write("Họ và tên sinh viên :");
                    tmp.HoVaTen = Console.ReadLine();
                }
            } while (tmp.HoVaTen.Length < 5);
            //Nhập địa chỉ
            Console.Write("Địa chỉ : ");
            tmp.DiaChi = Console.ReadLine();
            do
            {
                if (tmp.DiaChi.Length < 5)
                {
                    Console.WriteLine("Địa chỉ không hợp lệ (Địa chỉ >= 5 ký tự) !");
                    Console.Write("Địa chỉ : ");
                    tmp.DiaChi = Console.ReadLine();
                }
            } while (tmp.DiaChi.Length < 5);
            //Nhập năm sinh
            Console.Write("Năm sinh : ");
            tmp.NamSinh = Int32.Parse(Console.ReadLine());
            do
            {
                if (tmp.NamSinh > 2017)
                {
                    Console.WriteLine("Năm sinh không hợp lệ (năm sinh < 2017) !");
                    Console.Write("Năm sinh : ");
                    tmp.NamSinh = Int32.Parse(Console.ReadLine());
                }
            } while (tmp.NamSinh > 2017);
            //Nhập mã sinh viên
            Console.Write("Mã sinh viên : ");
            tmp.MaSinhVien = Console.ReadLine();
            do
            {
                if (tmp.MaSinhVien.Length != 5)
                {
                    Console.WriteLine("Mã sinh viên không hợp lệ (mã sinh viên = 5) ! ");
                    tmp.MaSinhVien = Console.ReadLine();
                }
            } while (tmp.MaSinhVien.Length != 5);
            sv = tmp;
        }
        public void SetSinhVien()
        {

            Console.WriteLine("\t Thông tin sinh viên : ");
            // Nhập họ và tên
            Console.Write("Họ và tên sinh viên :");
            string s = Console.ReadLine();
            do
            {
                if(s.Length < 5)
                {
                    Console.WriteLine("Họ và tên không hợp lệ (Họ và tên >= 5 ký tự) !");
                    Console.Write("Họ và tên sinh viên :");
                    s = Console.ReadLine();
                }
            } while (s.Length < 5);
            //Nhập địa chỉ
            Console.Write("Địa chỉ : ");
            string diaChi = Console.ReadLine();
            do
            {
                if (diaChi.Length < 5)
                {
                    Console.WriteLine("Địa chỉ không hợp lệ (Địa chỉ >= 5 ký tự) !");
                    Console.Write("Địa chỉ : ");
                    diaChi = Console.ReadLine();
                }
            } while (diaChi.Length < 5);
            //Nhập năm sinh
            Console.Write("Năm sinh : ");
            int namSinh = Int32.Parse(Console.ReadLine());
            do
            {
                if(namSinh > 2017)
                {
                    Console.WriteLine("Năm sinh không hợp lệ (năm sinh < 2017) !");
                    Console.Write("Năm sinh : ");
                    namSinh = Int32.Parse(Console.ReadLine());
                }
            } while (namSinh > 2017);
            //Nhập mã sinh viên
            Console.Write("Mã sinh viên : ");
            string maSinhVien = Console.ReadLine();
            do
            {
                if(maSinhVien.Length != 5)
                {
                    Console.WriteLine("Mã sinh viên không hợp lệ (mã sinh viên = 5) ! ");
                    maSinhVien = Console.ReadLine();
                }
            } while (maSinhVien.Length != 5);

            this.HoVaTen = HoVaTen;
            this.DiaChi = diaChi;
            this.NamSinh = namSinh;
            this.MaSinhVien = maSinhVien;
        }

        public void GetSinhVien()
        {
            Console.WriteLine("\t Thông tin sinh viên !");
            Console.WriteLine("Họ và tên : "+ this.HoVaTen);
            Console.WriteLine("Mã sinh viên : "+ this.MaSinhVien);
            Console.WriteLine("Năm sinh :" + this.NamSinh.ToString());
            Console.WriteLine("Đia chỉ :" + this.DiaChi);
        }
    }

    class DanhSachSinhVien : SinhVien
    {
        private List<SinhVien> listSinhVien;
        private int soLuong;
        public DanhSachSinhVien()
        {
            this.listSinhVien = new List<SinhVien>();
            this.soLuong = 0;
        }
        public DanhSachSinhVien( int soLuong)
        {
            this.listSinhVien = null ;
            this.soLuong = soLuong;
        }

        public void SetDanhSachSinhVien()
        {
            for(int i = 0; i < this.soLuong; i++)
            {
                SinhVien tmp = new SinhVien();
                tmp.SetSinhVien(out tmp);
                listSinhVien.Add(tmp);
            }
        }

        public void GetDanhSachSinhVien()
        {
            for(int i = 0; i < listSinhVien.Count; i++)
            {
                Console.WriteLine("Sinh viên thư {0} :\n" , i+1);
                listSinhVien[i].GetSinhVien();
            }
        }
    }
}
