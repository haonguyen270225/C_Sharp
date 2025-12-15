using System;
using System.Runtime.InteropServices;
namespace GreeksForGeeks
{
    public class DemoString
    {
        public static void KhaiBao()
        {
           

            // Các cách khai báo chuỗi !;
            string str1 = "C1/This is string in C# !";

            String str2 = "C2/This is string in C# !";

            string str3 = string.Format($"C3/This is string C# {str1} , {str2}");

            string str4 = "C4/" + str2 + str3;

          
            // Tạo ra 1 chỗi và sử dụng hàm tạo !
            Char[] tmp_str = { 'L', 'E', 'A', 'N', 'S', 't', 'i', 'n', 'g' };
            string str5 = new String(tmp_str);

            // Cách tạo chuỗi bằng phương thức khác !   
            string s = "Geeks For Geeks";   
            int start = s.IndexOf(" ") + 1;
            int end = s.IndexOf(" " , start) - start;

            string str6 = s.Substring(start, end);
            Console.WriteLine($"{str1}\n{str2}\n{str3}\n{str4}\n{str5}\nC6/{str6}");
        }
        

        // Sử dụng phương thức IndexOf();

        public static void _IndexOf()
        {
            // Với cách dùng Indexof(char x); -> Mang tính nạp chồng "different parameters "
            string strTmp = "Greeks For Geeks !";
            int index = strTmp.IndexOf('F');
            Console.WriteLine($"Vị trí ký tự 'F' trong chuỗi {strTmp} là : {index}");
            int index1 = strTmp.IndexOf('f');
            Console.WriteLine($"Vị trí ký tự 'f' trong chuỗi {strTmp} là : {index1}"); // Trả về - 1 ;-> Có phân biệt hoa thường;

            int  index2 = strTmp.IndexOf('A');
            Console.WriteLine($"Vị trí ký tự 'A' trong chuỗi {strTmp} là : {index2}"); // Trả về - 1 ;-> Có phân biệt hoa thường;
            int index3 = strTmp.IndexOf('e');
            Console.WriteLine($"Vị trí ký tự 'e' trong chuỗi {strTmp} là : {index3}"); // Nếu có nhiều ký tự giống nhau trả về kỹ tự đầu tiên trong chuỗi !
        }

        public static  void _IndexOf1()
        {
            // Với cách dùng IndexOf(char x , int start1); -- start1 vị trí bất đầu kiểm tra trong chuỗi ;

            string strTmp = "Đây là chuỗi C# !";
            int index1 = strTmp.IndexOf('ỗ', 6);
            Console.WriteLine($"Vị trí tìm thấy ký tự 'ỗ' trong chuỗi {strTmp} là {index1}");

            int index2 = strTmp.IndexOf('ỗ', 11);
            Console.WriteLine($"Vị trí tìm thấy ký tự 'ỗ' trong chuỗi {strTmp} là {index2}"); // không tìm thấy return - 1;

            int index3 = strTmp.IndexOf('D', 0);
            Console.WriteLine($"Vị trí tìm thấy ký tự 'D' trong chuỗi {strTmp} là {index3}"); // Không tìm thấy trả về -1;

            try
            {
                int index4 = strTmp.IndexOf('ỗ', -1);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Biến start1 trong IndexOf(char x , int start1) không được nhỏ hơn 0 ! ");
            }
        }


         public static  void _IndexOf2()
        {
            // Sử dụng phương thức IndexOf(char x , int start1 , int start2); -- Tìm kiếm từ vị trí start1 đến start2;

            string strTmp = "IndexOf in String !";

           // int index = strTmp.IndexOf('i' , 5 , strTmp.Length-1);
           int index = strTmp.IndexOf( 'i' , 5 , 10 );
           Console.WriteLine($"Sử dụng IndexOf(char x , int start1 , int start2 ) tìm vị trí ký tự 'i' trong chuỗi {strTmp} là  : {index}");

           int index1 = strTmp.IndexOf('i' , 1 , 7 );
           Console.WriteLine($"Sử dụng IndexOf(char x , int start1 , int start2 ) tìm vị trí ký tự 'i' trong chuỗi {strTmp} là  : {index1}");


            // Chú ý ngoại lệ xảy ra khi srart1
            // hoặc start2 là số âm  hoặc start1
            // lớn hơn độ dài hiện tại của chuỗi
            // hoặc start2 lớn hơn độ dài hiện tại của chuỗi trừ đi start1;

            // Trường hợp start1 or start2 âm;
            try
            {
                int index2 = strTmp.IndexOf('i' , 5 , - 1);
                Console.WriteLine($"Sử dụng IndexOf(char x , int start1 , int start2 ) tìm vị trí ký tự 'i' trong chuỗi {strTmp} là  : {index2}");
            }
            catch(Exception ex){
                Console.WriteLine($"Sử dụng IndexOf(i , 5 , -1) : \n" + ex.Message);
                Console.WriteLine("Không được dùng số âm trong start1 và start2 trong IndexOf(char x , int start1 , int start2)");
            }

            // Trường hợp start1 lớn hơn độ dài hiện tại cảu chuỗi !
            try
            {
                int index3 = strTmp.IndexOf('i' , 20 , 15);
                Console.WriteLine($"Sử dụng IndexOf(char x , int start1 , int start2 ) tìm vị trí ký tự 'i' trong chuỗi {strTmp} là  : {index3}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Sử dụng IndexOf(i , 20 , 15 ) : \n" + ex.Message);
                Console.WriteLine("Start1 trong IndexOf(char x , int Start1  , int Start2 ) không được lơn hơn độ dài của chuỗi là : {0}" , strTmp.Length);
            }

            // trường hợp start2 lớn hơn độ dài của chuỗi trừ đi start1
            try
            {
                int index4 = strTmp.IndexOf('i' , 5 , 15);
                Console.WriteLine($"Sử dụng IndexOf(char x , int start1 , int start2 ) tìm vị trí ký tự 'i' trong chuỗi {strTmp} là  : {index4}");
            }
            catch(Exception ex){
                Console.WriteLine($"Sử dụng IndexOf(i , 5 , 15 ) : \n" + ex.Message);
                Console.WriteLine("Start2 không được lớn hơn độ dài hiện tại của chuỗi trừ đi start1  ! ") ;

            }
        }

        public static void _IndexOf3()
        {
            // Sử dụng IndexOf(string s1);
            string strTmp = "Chuỗi trong C# !";

            int index = strTmp.IndexOf("trong");
            Console.WriteLine($"Sử dụng IndexOf(string s1) tìm kiếm chuỗi 'trong' ở vị trí là : {index} ");


            int index1 = strTmp.IndexOf("Trong");
            Console.WriteLine($"Sử dụng IndexOf(string s1) tìm kiếm chuỗi 'Trong' ở vị trí là : {index1} ");
        }

    }
}