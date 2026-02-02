using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace GreeksForGeeks
{
   class  DemoStartsWithAndEndsWith
    {
        static public void _StartsWith1()
        {
            // Sử dụng bool StartsWith(string input_string);
            // Khai báo một chuỗi để so sánh;
            string strTmp = "GreeksForGeeks";

            bool chk = strTmp.StartsWith("Greek"); // trả về true;
            Console.WriteLine(chk);
            if (chk)
            {
                Console.WriteLine($"{strTmp} bất đầu chuỗi bằng {"Geek"}!");
            }
            else
            {
                Console.WriteLine($"{strTmp} không bất đầu chuỗi bằng {"Geek"}!");
            }


            bool chk1 = strTmp.StartsWith("greek"); // trả về false;
            Console.WriteLine(chk1);
            if (chk1)
            {
                Console.WriteLine($"{strTmp} bất đầu chuỗi bằng {"geek"}!");
            }
            else
            {
                Console.WriteLine($"{strTmp} không bất đầu chuỗi bằng {"geek"}!"); // Mặc định StartsWith có phần biệt hoa thường !
            }


            bool chk2 = strTmp.StartsWith("Greekk"); // trả về false;
            Console.WriteLine(chk2);
            if (chk2)
            {
                Console.WriteLine($"{strTmp} bất đầu chuỗi bằng {"greEkk"}!");
            }
            else
            {
                Console.WriteLine($"{strTmp} không bất đầu chuỗi bằng {"greEkk"}!"); // Mặc định StartsWith có phần biệt hoa thường !
            }


            // Chú ý : Sử dụng bool StartsWith(string input_string); nếu input_string là null thì sẽ ném ra ngoại lệ ArgumentNullException.
            
            try
            {
                string sdemo = null;
                bool chkdemo = strTmp.StartsWith(sdemo);
                if (chkdemo)
                {
                    Console.WriteLine($"{strTmp} bất đầu chuỗi bằng {sdemo}!");
                }
                else
                {
                    Console.WriteLine($"{strTmp} không bất đầu chuỗi bằng {sdemo}!"); 
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Sử dụng StartsWith(string input_string) : " + ex.Message );
                Console.WriteLine("input string không được null trong StartsWith(string input_string)!");
            }
          
        }


        static public void _ExampleStarsWith1()
        {
            string SearchLink = "https://www.geeksforgeeks.org/questions/find-the-values-of-a-b-c-and-d/-guide/";

            string[] addLink =
            {
            "https://www.geeksforgeeks.org///",
            "https://www.geeksforgeeks.org//",
            "https://www.geeksforgeeks.org/questions/find-the-values-of-a-b-c-and-d/"
            };
            // Kiểm tra đường dẫn trong addLink bằng với chuỗi bất đầu trong Search;
            foreach(string i in addLink){
                if (SearchLink.StartsWith(i))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }

        static public void _ExampleStarsWith2()
        {
            // Xóa các thể mở trong mã các chuỗi mã HTML sau :  
            string[] intPut = 
            {
                "<p>GeekforGeeks Computer Science Portal </p>",
                "<h1>GeekforGeeks Sudo Placement </h1>",
                "<h2>GeekforGeeks Placement Preparation </h2>",
                "<h4>GeekforGeeks Contribute ",
                "<h5>GeekforGeeks Interview </h5>"
            };

            Console.WriteLine("Các chuỗi HTML  đã xóa các thể mở : ");
            for (int i = 0 ; i < intPut.Length; i++)
            {

                while (intPut[i].Trim().StartsWith('<'))
                {
                    int end = intPut[i].IndexOf('>');
                    if(end >= 0)
                    {
                        intPut[i] = intPut[i].Substring(end + 1);
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(intPut[i]);
            }
        }


        static public void _StartsWith2()
        {
            /*Sử dụng phương thức bool StartsWith(string str, bool case , CultureInfo cul);
                Các tham số:
                string str : Chuỗi đầu vào!;
                bool case :
                true->so sánh không phân biệt hoa thường ngược lại là false;
                Culture cul : Xác định culture khi so sánh chuỗi đại diện cho ngôn ngữ +vùng!.Thuộc namespace System.Globalization
             vd : ngôn ngữ + Việt Nam, Hoa Kỳ , Thổ Nhĩ Kỳ.Và quyết định :
                   Quy tắc chữ hoa/thường
                   Dấu(accent)
                   Một số ký tự đặc biệt
                   Cách so sánh ký tự
             Nên dùng :
                CultureInfo.InvariantCulture -> so sánh thoe ID, mã, UerName
                CultureInfo.CurrentCulture(an toàn) theo ngôn ngữ hệ thống !
             Ngôn ngữ cụ thể :
                new CultureInfo("vi-VN")
                new CultureInfo("en-US")*/

            string strTmp1 = "Greeks!For";
            bool chk1 = strTmp1.StartsWith("Greeks", true, new CultureInfo("vn-VN"));
            
            Console.WriteLine("Sử dụng : Greeks!For.StartsWith(\"Greeks\", true, new CultureInfo(\"vn-VN\") = {0}" , chk1);
            Console.WriteLine(chk1);

            string strTmp2 = "Nguyễn Văn A";
            bool chk2 = strTmp2.StartsWith("Nguyễn" , true , new CultureInfo("vn-VN"));
            Console.WriteLine("Sử dụng: Nguyễn Văn A.StartsWith(\"Nguyễn\", true, new CultureInfo(\"vn-VN\") = {0}", chk2);
            Console.WriteLine(chk2);


            // Chú ý sử dụng bool StartsWith(string str , bool case , CultureInfo cul) sẽ trả về lỗi ArgumentNullException;

            string strTmpdemo = null;
            try
            {
                bool chkdemo = strTmp1.StartsWith(strTmpdemo, true, new CultureInfo("vn-Vn"));
            }
            catch (Exception e) 
            {
                    Console.WriteLine("Lỗi : string không được phép null trong StartsWith(string str , bool case , CultureInfo cul) \n" + e.ToString());
            }
        }
    }
}