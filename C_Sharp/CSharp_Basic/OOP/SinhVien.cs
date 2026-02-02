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
        #region ThuocTinh
        private string HoVaTen;
        private string DiaChi;
        private int NamSinh;
        private string MaSinhVien;
        #endregion
        #region PhuongThuc
        public string MHoVaTen
        {
            set { this.HoVaTen = HoVaTen; }
            get { return this.HoVaTen; }
        }
        public int MNamSinh
        {
            set { this.NamSinh = NamSinh; }
            get { return this.NamSinh; }
        }
        public string MDiaChi
        {
            set { this.DiaChi = DiaChi; }
            get { return this.DiaChi; }
        }
        public string MMaSinhVien
        {
            set { this.MaSinhVien = MaSinhVien; }
            get { return this.MaSinhVien; }
        }
        public SinhVien()
        {
            HoVaTen = "";
            DiaChi = "";
            NamSinh = 0;
            MaSinhVien = "";
        }
        public void SetSinhVien()
        {

            Console.WriteLine("\t Thông tin sinh viên : ");
            // Nhập họ và tên
            Console.Write("Họ và tên sinh viên :");
            string hoVaTen = Console.ReadLine().Trim();

            do
            {
                if (hoVaTen.Length < 5)
                {
                    Console.WriteLine("Họ và tên không hợp lệ (Họ và tên >= 5 ký tự) !");
                    Console.Write("Họ và tên sinh viên :");
                    hoVaTen = Console.ReadLine().Trim();

                }
            } while (hoVaTen.Length < 5);
            //Nhập địa chỉ
            Console.Write("Địa chỉ : ");
            string diaChi = Console.ReadLine().Trim();

            do
            {
                if (diaChi.Length < 5)
                {
                    Console.WriteLine("Địa chỉ không hợp lệ (Địa chỉ >= 5 ký tự) !");
                    Console.Write("Địa chỉ : ");
                    diaChi = Console.ReadLine().Trim();

                }
            } while (diaChi.Length < 5);
            //Nhập năm sinh
            Console.Write("Năm sinh : ");
            int namSinh = Int32.Parse(Console.ReadLine());
            do
            {
                if (namSinh > 2017)
                {
                    Console.WriteLine("Năm sinh không hợp lệ (năm sinh < 2017) !");
                    Console.Write("Năm sinh : ");
                    namSinh = Int32.Parse(Console.ReadLine());
                }
            } while (namSinh > 2017);
            //Nhập mã sinh viên
            Console.Write("Mã sinh viên : ");
            string maSinhVien = Console.ReadLine().Trim();

            do
            {
                if (maSinhVien.Length != 5)
                {
                    Console.WriteLine("Mã sinh viên không hợp lệ (mã sinh viên = 5) ! ");
                    maSinhVien = Console.ReadLine().Trim();

                }
            } while (maSinhVien.Length != 5);


            this.HoVaTen = hoVaTen;
            this.DiaChi = diaChi;
            this.NamSinh = namSinh;
            this.MaSinhVien = maSinhVien;
        }

        public void GetSinhVien()
        {
            Console.WriteLine("\t Thông tin sinh viên !");
            Console.WriteLine("Họ và tên : " + this.HoVaTen);
            Console.WriteLine("Mã sinh viên : " + this.MaSinhVien);
            Console.WriteLine("Năm sinh :" + this.NamSinh.ToString());
            Console.WriteLine("Đia chỉ :" + this.DiaChi);
        }
        #endregion
    }


    class DanhSachSinhVien
    {
        #region ThuocTinh
        public List<SinhVien> listSinhVien;
        private int soLuong;
        #endregion

        #region PhuongThuc
        public int MSoLuong
        {
            set { this.soLuong = soLuong; }
            get { return this.soLuong; }
        }

        public DanhSachSinhVien()
        {
            this.listSinhVien = new List<SinhVien>();
            this.soLuong = 0;
        }
        public DanhSachSinhVien(int soLuong)
        {
            this.listSinhVien = new List<SinhVien>(soLuong);
            this.soLuong = soLuong;
        }

        public void SetDanhSachSinhVien()
        {
            for (int i = 0; i < this.soLuong; i++)
            {
                SinhVien tmp = new SinhVien();
                tmp.SetSinhVien();
                listSinhVien.Add(tmp);
            }
        }

        public void GetDanhSachSinhVien()
        {
            string add = "STT".PadRight(5) + "MaSinhVien".PadRight(20) + "HoVaTen".PadRight(20) + "DiaChi".PadRight(20) + "NamSinh\n";
            Console.WriteLine(add);
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                string tmp = i.ToString().PadRight(5) + listSinhVien[i].MMaSinhVien.PadRight(20) + listSinhVien[i].MHoVaTen.PadRight(20) + listSinhVien[i].MDiaChi.PadRight(20) + listSinhVien[i].MNamSinh.ToString() + "\n";
                Console.WriteLine(tmp);
            }
        }
        #endregion
    }
}
