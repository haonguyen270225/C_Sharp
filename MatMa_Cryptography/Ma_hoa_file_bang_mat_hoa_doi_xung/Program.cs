using System;
using System.IO;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

public class SymmetricEncryptionExample
{
    public static void Main(string[] args)
    {
        // Tạo một giải thuật Triple DES mới để thu lấy khóa dùng cho ví dụ.
        // Khóa này sẽ được dùng trong phương thức EncryptFile và DecryptFile.
        // Bình thường khóa được thỏa thuận với người gửi và người nhận hoặc được gửi bởi người gửi cùng với file đã được mật hóa.
        byte[] key;
        byte[] iv;
        using (SymmetricAlgorithm alg = SymmetricAlgorithm.Create("3DES"))
        {
            key = alg.Key;
            iv = alg.IV;
        }

        // Mật hóa file. Tiền tố "encrypted" sẽ được thêm vào tên file nguồn và được sử dụng làm tên của file được mật hóa.
         EncryptFile(args[0], "encrypted" + args[0], (byte[])key.Clone(), (byte[])iv.Clone());

        // Giải mật hóa file đã được mật hóa. Tiền tố "decrypted" đã được thêm vào tên file gốc và được dử dụng làm tên của file đã được giải mật hóa.
        DescryptFile("encrypted"+args[0], "descrypted" + args[0], key, iv);
    }

    // Phương thức dùng để mật hóa một file (bằng giải thuật Triple DES);
    // với key và iv cho trước;
    private static void EncryptFile(string srcFileName , string destFileName , byte[] key , byte[] iv)
    {
        // Tạo các stream để truy suất file nguồn và file đích;
        Stream srcFile = new FileStream(srcFileName, FileMode.Open, FileAccess.Read);
        Stream destFile = new FileStream(destFileName, FileMode.Create, FileAccess.Write);

        // Tạo một giải thuật Triple DES mới để mật hóa file.
        using (SymmetricAlgorithm alg = SymmetricAlgorithm.Create("3DES"))
        {
            // Cấu hình thuộc tính key và iv;
            alg.Key = key;
            alg.IV = iv;

            // Tạo một CryptoStream để mật hóa nội dung của Stream nguồn khi được đọc. Gọi phương thức CreateEncryptor của SymmetricAlgorith
            // để nhận thể hiện ICrypto Transform và truyền nó cho CryptoStream
            CryptoStream cryptoStream = new CryptoStream(srcFile, alg.CreateEncryptor(), CryptoStreamMode.Read);

            // Khai báo một bộ đệm dùng để đọc dữ liệu từ file nguồn
            // thông qua CryptoStream và ghi nó ra file đích;
            int bufferLength;
            byte[] buffer = new byte[1024];

            // Đọc file nguồn từng khối (1024 byte) và ghi phiên bản đã được mật hóa ra file đích;
            do
            {
                bufferLength = cryptoStream.Read(buffer, 0, 1024);
                destFile.Write(buffer, 0, bufferLength);
            } while (bufferLength > 0);

            // Đóng stream và xóa các dữ liệu bí mật;
            destFile.Flush();
            Array.Clear(key, 0, key.Length);
            Array.Clear(iv, 0, iv.Length);
            cryptoStream.Clear();
            cryptoStream.Close();
            srcFile.Close();
            destFile.Close();
        }
    }
    
    // Phương thức dùng để giải mật hóa một file đã được mật hóa bằng giải thuật Triple DES với key và iv cho trước;

    private static void DescryptFile(string srcFileName , string destFileName , byte[] key , byte[] iv)
    {
        // Tạo các stream để truy xuất file nguồn và file đích.
        Stream srcFile = new FileStream(srcFileName , FileMode.Open , FileAccess.Read);
        Stream destFile = new FileStream(destFileName, FileMode.Create, FileAccess.Write);

        // Tạo một thuật toán Triple DES mời để giải mật hóa file.
        using (SymmetricAlgorithm alg = SymmetricAlgorithm.Create("3DES"))
        {
            // Cấu hình thuộc tính key và iv của giải thuật;
            alg.Key = key;
            alg.IV = iv;

            // Tạo một CryptoStream để giải mật hóa nội dung của dữ liệu
            // đã được mật hóa khi nó được ghi. Gọi phương thức CreateDecryptor của SymmetricAlgorithm để nhận
            // thể hiện ICryptoStream và truyền nó cho CryptoStream.
            CryptoStream cryptoStream = new CryptoStream(destFile, alg.CreateDecryptor(), CryptoStreamMode.Write);

            // Khai báo bộ đệm dùng để đọc dữ liệu từ file đã được mật hóa và ghi ra file 
            // đích thông qua CryptoStream
            int bufferLength;
            byte[] buffer = new byte[1024];

            // Đọc file đã được mật hóa (từng khối 1024 byte) và ghi
            // phiên bản đã được giải mật hóa ra file đích.
            do
            {
                bufferLength = srcFile.Read(buffer, 0, 1024);
                cryptoStream.Write(buffer, 0, bufferLength);
            }while (bufferLength > 0);
            // Đóng stream và xóa dữ liệu bí mật.
            cryptoStream.FlushFinalBlock();
            Array.Clear (key, 0, key.Length);
            Array.Clear(iv, 0, iv.Length);
            cryptoStream.Clear();
            cryptoStream.Close();
            srcFile.Close();
            destFile.Close();
        }
    }
}
