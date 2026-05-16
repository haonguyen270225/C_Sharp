/*
 Đề : 
Bài tập C#: Kiểm tra tên đăng nhập và mật khẩu
Viết chương trình C# để nhận Username và Password dưới dạng kiểu dữ liệu chuỗi từ người dùng. Nếu người dùng nhập sai, in thông báo lỗi

Đây là chương trình C# cơ bản giúp bạn làm quen với kiểu dữ liệu string trong C# cũng như thực hiện phép toán với kiểu dữ liệu này.
 
 */

using System;
class Program
{
    static void Main(string[] args)
    {
        string user, password;
        Console.Write("Kiem tra ten dang nhap va mat khau:\n");
        Console.Write("Gia tri mac dinh la: user va password\n");
        Console.Write("---------------------------------\n");

        do
        {
            Console.Write("Ten dang nhap: ");
            user = Console.ReadLine();

            Console.Write("Mat khau: ");
            password = Console.ReadLine();
        }
        while (user != "user" && password != "password");

        Console.WriteLine("Ten dang nhap va mat khau sai!");

        Console.ReadKey();

    }
}