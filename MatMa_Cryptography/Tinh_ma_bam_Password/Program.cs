/* Tạo một mã băm từ chuỗi password !*/

using System;
using System.Text;
using System.Security.Cryptography;

public class HashPassWordExample
{
    public static void Main(string []args)
    {
        // Tạo HashAlgorithm của kiểu được chi định bởi đối số dòng lệnh thứ nhất !;
        using (HashAlgorithm hashAlg = HashAlgorithm.Create(args[0]))
        {

            // Chuyển đổi password (đối số dòng lệnh thứ hai !) thành một mảng byte;
            byte[] passWordData = Encoding.Default.GetBytes(args[1]);

            // Tạo mảng băm của passworrd;
            byte[] hashPassWord = hashAlg.ComputeHash(passWordData);


            // Hiển thị mã băm của password;
            Console.WriteLine(BitConverter.ToString(hashPassWord));
        }
    }
}