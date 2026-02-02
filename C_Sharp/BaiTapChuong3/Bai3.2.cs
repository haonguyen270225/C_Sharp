using System;
using System.Net.WebSockets;
using System.Runtime.InteropServices.Marshalling;

namespace Bai3_2;


    class Nguoi
    {
        #region ThuocTinh
        private string hoVaTen;
        private string maSo;
        private float luong;
        #endregion
        #region Set_Get
        public string HoVaTen
        {
            get {  return hoVaTen; }
            set
            {
                
                do
                {
                    if (value.Length <= 3)
                    {
                        Console.WriteLine("Tên không hợp lệ !");
                        Console.WriteLine("Nhập lại họ và tên : ");
                        value = Console.ReadLine();
                    }
                } while (value.Length <= 3);
                hoVaTen = value;
            }
        }
        public string MaSo
        {
            get { return  maSo; }
            set
            {
                do
                {
                    if (value.Length < 5) 
                    {
                        Console.WriteLine("Mã số không hợp lệ !");
                        Console.WriteLine("Nhập lại mã số: ");
                        value = Console.ReadLine();
                    }
                } while (value.Length < 5);
                maSo = value;
            }
        }
        public float Luong
        {
            get { return  luong; }
            set
            {
                do
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Lương không hợp lệ ");
                       value = float.Parse(Console.ReadLine());
                    }
                } while (value < 0);
                luong = value;
            }
        }
        #endregion
        #region HamDung
        public Nguoi()
        {
            this.hoVaTen = "";
            this.maSo = "";
            this.luong = 0;
        }
        public Nguoi(string hoVaTen, string maSo, float luong)
        {
            this.HoVaTen = hoVaTen;
            this.MaSo = maSo;
            this.Luong = luong;
        }
        #endregion
        #region PhuongThuc
        public virtual void NhapThongTin()
        {
            Console.Write("Họ và tên : ");
            this.HoVaTen = Console.ReadLine();
            Console.Write("Mã số :");
            this.MaSo = Console.ReadLine();
        }
        public virtual void  XuatThongTinNguoi()
        {

            //string tmp = string.Format($"{this.maSo.ToString().PadRight(10)}{this.hoVaTen.ToString().PadRight(30)}{this.luong}\n");
            Console.WriteLine($"{this.maSo.ToString().PadRight(10)}{this.hoVaTen.ToString().PadRight(30)}{this.luong}\n");
        }

        public virtual void TinhLuong() { }

        #endregion
    }

    class BienChe : Nguoi
    {
        #region ThuocTinh
        private float heSoLuong;
        private float heSoPhuCap;
        private float luongCoBan;
        #endregion
        #region Set_Get
        public float LuongCoBan
        {
            get { return luongCoBan; }
            set
            {
                do
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Lương cơ bản không hợp lệ !");
                        Console.Write("Nhập lương cơ bản :");
                        value = float.Parse(Console.ReadLine());
                    }
                } while (value <= 0);
                luongCoBan = value;
            }
        }
        public float HeSoLuong
        {
            get { return heSoLuong; }
            set
            {
                do
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Hệ số lương không hợp lệ !");
                        Console.Write("Nhập hệ số lương :");
                        value = float.Parse(Console.ReadLine());
                    }
                } while (value <= 0);
                heSoLuong = value;
            }
        }
        public float HeSoPhuCap
        {
            get { return heSoPhuCap; }
            set
            {
                do
                {
                    if (value <= 0 )
                    {
                        Console.WriteLine("Hệ số phụ cấp không hợp lệ !");
                        Console.Write("Nhập hệ số phụ cấp :");
                        value = float.Parse(Console.ReadLine());
                    }
                } while (value <= 0);
                heSoPhuCap = value;
            }
        }

        #endregion
        #region HamDung
        public BienChe(float luongCoBan, float heSoLuong, float heSoPhuCap, string hoVaTen, string maSo, float luong) : base(hoVaTen, maSo, luong)
        {
            this.LuongCoBan = luongCoBan;
            this.HeSoLuong = heSoLuong;
            this.HeSoPhuCap = heSoPhuCap;
            this.TinhLuong();
        }

        public BienChe() : base()
        {
            this.luongCoBan = 0;
            this.heSoLuong = 0;
            this.heSoPhuCap = 0;
        }

        #endregion
        #region PhuongThuc
        public override void TinhLuong()
        {
            this.Luong = this.LuongCoBan * (1.0f + this.HeSoLuong + this.HeSoPhuCap);
        }
        public override void XuatThongTinNguoi()
        {
            Console.Write($"{"Biên Chế".ToString().PadRight(15)}");
            base.XuatThongTinNguoi();
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Lương cơ bản :");
            this.LuongCoBan = float.Parse(Console.ReadLine());
            Console.Write("Hệ số lương :");
            this.HeSoLuong = float.Parse(Console.ReadLine());
            Console.Write("Hệ số phụ cấp :");
            this.HeSoPhuCap = float.Parse(Console.ReadLine());
            this.TinhLuong();
        }
        #endregion
    }


    class HopDong : Nguoi
    {
        #region ThuocTinh
        private float tienCong;
        private float ngayCong;
        private float heSoVuotGio;
        #endregion

        #region Get_Set
        
        #endregion
    }


