/* Tạo mã băm cho file : băm không có khóa !*/
using System;
using System.IO;
using System.Security.Cryptography;

public class HashStreamExample
{
    public static void Main(string[] args)
    {
        // Tạo một HashAlgotithm với kiểu được chỉ định trong đối số dòng lệnh thứ nhất;
        using (HashAlgorithm hashAlg = HashAlgorithm.Create(args[0]))
        {
            // Mở một FileStream cho file được chỉ định trong đối số dòng lệnh thứ hai;
            using (Stream file = new FileStream(args[1], FileMode.Open))
            {
                // Tạo mã băm cho nội dung của file;
                byte[] hash = hashAlg.ComputeHash(file);

                // Hiển thị mã băm
                Console.WriteLine(BitConverter.ToString(hash));
            }
        }
    }
}