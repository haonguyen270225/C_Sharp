//using System;
namespace Bai3_1
{
    class TaiKhoanNganHang
    {
        #region ThuocTinh
        private static List<TaiKhoanNganHang> list = new List<TaiKhoanNganHang>();
        private string tenTaiKhoan;
        private double soDuTaiKhoan;
        private int soTaiKhoan;
        #endregion

        // Hàm dựng không tham số;
        #region HamDung
        public TaiKhoanNganHang()
        {
            this.tenTaiKhoan = "";
            this.soTaiKhoan = 0;
            this.soDuTaiKhoan = 0.0;
            TaiKhoanNganHang.S_AddTaiKhoan(this);
        }

        // Hàm dựng có tham số;
        public TaiKhoanNganHang(string tenTaiKhoan, int soTaiKhoan, double soDuTaiKhoan)
        {
            this.tenTaiKhoan = tenTaiKhoan;
            this.soTaiKhoan = soTaiKhoan;
            this.soDuTaiKhoan = soDuTaiKhoan;
            TaiKhoanNganHang.S_AddTaiKhoan(this);
        }
        #endregion
        #region Set_Get
        public int SoTaiKhoan
        {
            set { soTaiKhoan = value; }
            get { return soTaiKhoan; }
        }

        public string TenTaiKhoan
        {
            set { tenTaiKhoan = value; }
            get { return tenTaiKhoan; }
        }

        public double SoDuTaiKhoan
        {
            set { this.soDuTaiKhoan = value; }
            get { return soDuTaiKhoan; }
        }
        #endregion
        #region S_PhuongThuc
        public static void S_PrintThongTin(TaiKhoanNganHang taiKhoanNganHang)
        {
            Console.WriteLine($"{taiKhoanNganHang.SoTaiKhoan.ToString().PadRight(30)}{taiKhoanNganHang.TenTaiKhoan.ToString().PadRight(40)}{taiKhoanNganHang.SoDuTaiKhoan.ToString()}\n");
        }


        public static void S_AddTaiKhoan(TaiKhoanNganHang taiKhoanNganHang)
        {
            list.Add(taiKhoanNganHang);
        }

        public static void S_ThongTinDanhSachTaiKhoan()
        {
            Console.WriteLine($"{"Mã tài khoản".ToString().PadRight(30)}{"Tên tài khoản".ToString().PadRight(40)}{"Số dư"}\n");
            foreach (var tK in list)
            {
                TaiKhoanNganHang.S_PrintThongTin(tK);
            }

        }
        #endregion
        #region PhuongThuc
        public void GuiTien(double money)
        {
            Console.WriteLine("Gọi hàm Gửi Tiền !");
            this.soDuTaiKhoan += money;
            Console.WriteLine("Số tiền : " + soDuTaiKhoan.ToString() + "\n");
        }

        public void RutTien(double money)
        {
            Console.WriteLine("Gọi hàm Rút Tiền !");
            this.soDuTaiKhoan -= money;
            Console.WriteLine("Số tiền : " + soDuTaiKhoan.ToString() + "\n");

        }

        public void ChuyenTien(TaiKhoanNganHang taiKhoanNganHang, double money)
        {
            // Không sử lại lại hàm RutTien va GuiTien
            if (this.soDuTaiKhoan <= money)
            {
                Console.WriteLine("Không thể chuyển tiền ! Ví số tài {0} khoản không đủ !  \n", this.tenTaiKhoan);
            }
            else
            {
                this.soDuTaiKhoan -= money;
                taiKhoanNganHang.soDuTaiKhoan += money;
                Console.WriteLine(" Đã chuyển tiền thành công ! \n");
                Console.WriteLine(" Số dư tài khoản  chuyển tiền  : {0}\n", this.soDuTaiKhoan);
                Console.WriteLine(" Số dư tài khoản được chuyển : {0}\n", taiKhoanNganHang.soDuTaiKhoan);
            }
        }

        public void ChuyenTienC2(TaiKhoanNganHang taiKhoanNganHang, double money)
        {
            // Sử dụng lại hàm RutTien và hàm GuiTien;
            if (this.soDuTaiKhoan <= money)
            {
                Console.WriteLine("\n Không thể chuyển tiền ! Ví số tài {0} khoản không đủ !  \n", this.tenTaiKhoan);
            }
            else
            {
                this.RutTien(money);
                taiKhoanNganHang.GuiTien(money);
                Console.WriteLine(" Đã chuyển tiền thành công ! \n");
                Console.WriteLine(" Số dư tài khoản  chuyển tiền  : {0}\n", this.soDuTaiKhoan);
                Console.WriteLine(" Số dư tài khoản được chuyển : {0}\n", taiKhoanNganHang.soDuTaiKhoan);

            }
        }

        #endregion
    }
}
