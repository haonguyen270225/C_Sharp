/* Sử dụng lớp System.Security.Cryptography để tạo số ngẫu nhiên !  */
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;


public class SecureRandomNumberExample
{
    //// Hàm tạo số ngẫu nhiên toàn phạm vi !;
    //public static int GenerateRandomInt() 
    //{
    //    byte[] number = new byte[4]; // 4 byte = 32 bit tương đương với kích thước int;
    //    RandomNumberGenerator rng = RandomNumberGenerator.Create();
        
    //    rng.GetBytes(number);

    //    return BitConverter.ToInt32(number, 0);
    //}

    //// Hàm tạo số ngẫu nhiên trong khoản [min , max);

    //public static int GenerateRandomIntRange(int min , int max)
    //{
    //    if(min >= max)
    //    {
    //        throw new ArgumentException("min phải nhỏ hơn max !"); // ArgumentException : Ngoại lệ tham số không hợp lệ;
    //    }
    //    long range = (long)max - min; // Khoản cách giữa min và max;

    //    byte[] number = new byte[8]; // dùng 8 byte để tránh bias (thiên vị ) khi chia;
    //    RandomNumberGenerator rng = RandomNumberGenerator.Create();

    //    rng.GetBytes(number);
    //    ulong randomValue = BitConverter.ToUInt64(number, 0); // ulong : Số nguyên không dấu 64-bit

    //    // Tính toán để phân bố tránh thiên vị !;
    //    ulong scaled = (ulong)((randomValue * (ulong)range) >> 64);
    //    return min + (int)scaled;
    //}


    public static void Main(string[] args)
    {
        // Tạo một mảng byte dùng để lưu trữ dữ liệu ngẫu nhiên !;
        byte[] number = new byte[32];
        
        // Tạo một số ngẫu nhiên mặc định !
        RandomNumberGenerator rng = RandomNumberGenerator.Create();

        // tạo dữ liệu ngẫu nhiên;
        rng.GetBytes(number);

        // Hiển thị dữ liệu ngẫu nhiên;
        Console.WriteLine(Convert.ToBase64String(number));


        //// Ham GenerateRandomInt();
        //Console.WriteLine("Số ngẫu nhiên int (toàn phạm vi) :" + GenerateRandomInt());
        //// Hiển thị số ngẫu nhiên từ 1 -> 1000;
        //Console.WriteLine("Số ngẫu nhiên từ 1 -> 1000 :" + GenerateRandomIntRange(1, 1000)); -- error;

        /* Tạo số ngẫu nhiên từ 0 - 99 (không bao gồm 100) */
        int randomNumber = RandomNumberGenerator.GetInt32(100);
        Console.WriteLine("Số ngẫu nhiên từ 0 -> 99 là : " + randomNumber);

        /* Tạo số ngẫu nhiên từ 10 đến 50 (bao gồm 10 không bao gồm 51) */
        int randomNumberRange = RandomNumberGenerator.GetInt32(10, 51);
        Console.WriteLine("Tạo số ngẫu nhiên từ 10  đến 50 : " + randomNumberRange);

        /* Tạo chuỗi ký tự ngẫu nhiên (Hex String !)*/
        string hexString = RandomNumberGenerator.GetHexString(10);
        Console.WriteLine("Tạo chuỗi 10 ký tự ngẫu nhiên :" + hexString);
    }
}