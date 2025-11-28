using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp_Basic
{
    internal class Format_WriteLines
    {


        public static void LearnWriteLine()
        {
            Console.WriteLine("Các dạng số chuẩn !");
            Console.WriteLine(
                "(C) Currency.........................{0:C}\n" +
                "(D) Decimal..........................{0:D}\n" +
                "(E) Scientific..........................{1:E}\n" +
                "(F) Fixel Point..........................{0:F}\n" +
                "(G) General..........................{0:G}\n" +
                "   (default)..........................{0}(default = 'G')\n" +
                "(N) Number..........................{0:N}\n" +
                "(P) Percent..........................{1:P}\n" +
                "(R) Round-trip..........................{1:R}\n" +
                "(X) Hexadecimal..........................{0:X}\n"
                , -123, -123.45f
            );

            
            /*
            Các dạng số chuẩn !
            (C)Currency.........................($123.00)
            (D)Decimal..........................-123
            (E) Scientific..........................-1.234500E+002
            (F) Fixel Point..........................-123.00
            (G) General..........................-123
               (default)..........................-123(default = 'G')
            (N) Number..........................-123.00
            (P) Percent..........................-12,345.00 %
            (R)Round - trip..........................-123.45
            (X) Hexadecimal..........................FFFFFF85
            */

            //Định dạng       Tên tiếng Anh                         Ý nghĩa              Ví dụ
            //C                Currency                         Tiền tệ                 ₫123.00    -> dạng tiền tệ  trong Việt Nam sẽ là đ us sẽ là $.
            //D                Decimal                          Số nguyên thập phân     123        -> dạng số nguyên thập phân Format cho số nguyên , không dùng cho float / double.
            //E                Scientific                       Dạng khoa học           1.2345E+02 -> dạng khoa học mũ thường dùng trong vật lý or toán 
            //F                Fixed-point                      Số thập phân cố định    123.00   -> Hiển thị số thập phân cố định , mặc định là 2 .
            //G                General                          Dạng phù hợp            123      -> khi bạn không muốn định dạng C# sẽ giúp hiển thị tối ưu nhất , nếu số lớn -> sang dạng khoa học , số vừa -> sang số thường
            //N                Number                           Có dấu phẩy             1,000,000 -> giúp dễ đọc hơn
            //P                Percent                          Phần trăm               12,345 %  -> ký hiệu phần trăm
            //R                Round - trip                     Giữ nguyên giá trị      123.45    -> ra đúng giá trị ban đầu thường dùng để lưu file , log  , serialization.
            //X                Hexadecimal                      Hệ 16                   7B


            Console.WriteLine("Định dạng ngày chuẩn !");
            Console.WriteLine(
                "(d) Short date :................................{0:d}\n" +
                "(D) Long  date :................................{0:D}\n" +
                "(t) Short time :................................{0:t}\n" +
                "(T) Long date :................................{0:T}\n" +
                "(f) Full date / Short time :................................{0:f}\n" +
                "(F) Full date / Long time :................................{0:F}\n" +
                "(g) General date / Short time :................................{0:g}\n" +
                "(G) General date / Long time :................................{0:G}\n" +
                "(M) Month :................................{0:M}\n" +
                "(R) RFC1123 :................................{0:R}\n" +
                "(s) Sortable :................................{0:s}\n" +
                "(u) Universal sortable :................................{0:u}\n" +
                "(U) Universal full date/time :................................{0:U}\n" +
                "(Y) Year :................................{0:Y}\n",
                DateTime.Now);

            /*
            Định dạng ngày chuẩn !
            (d)Short date: ................................11 / 29 / 2025
            (D) Long date :................................Saturday, November 29, 2025
            (t) Short time :................................1:41 AM
            (T) Long date :................................1:41:39 AM
            (f) Full date / Short time: ................................Saturday, November 29, 2025 1:41 AM
            (F) Full date / Long time: ................................Saturday, November 29, 2025 1:41:39 AM
            (g) General date / Short time: ................................11 / 29 / 2025 1:41 AM
            (G) General date / Long time: ................................11 / 29 / 2025 1:41:39 AM
            (M) Month: ................................November 29
            (R) RFC1123: ................................Sat, 29 Nov 2025 01:41:39 GMT
            (s) Sortable: ................................2025 - 11 - 29T01: 41:39
            (u) Universal sortable :................................2025 - 11 - 29 01:41:39Z
            (U) Universal full date / time :................................Friday, November 28, 2025 6:41:39 PM
            (Y) Year: ................................November 2025
            */
        }

    }
}
