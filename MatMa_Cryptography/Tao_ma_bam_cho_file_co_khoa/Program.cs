/* Tạo  mã băm có khóa cho file ! */
using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

public class KeyedHashStreamExample
{
    public static void Main(string[] args)
    {
        // Tạo một mang byte từ chuỗi key là đối số thứ hai !;
        byte[] key = Encoding.Unicode.GetBytes(args[1]);

        // Tạo một đối tượng HMACSHA1
        using (HMACSHA1 hashAlg = new HMACSHA1(key))
        {
            // Mở một FileStream để đọc file tên file được chỉ định trong đối số dòng lệnh thứ nhất.
            using (Stream file = new FileStream(args[0] , FileMode.Open))
            {
                // Tạo mã băm có khóa cho nội dung file;
                byte[] hash = hashAlg.ComputeHash(file);

                // Hiển thị mã băm có khóa ra cửa sổ Console;
                Console.WriteLine(BitConverter.ToString(hash));
            }
        }
    }
}
