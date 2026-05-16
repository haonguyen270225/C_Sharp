/* Đề :
 Bài tập C#: Vẽ tam giác số
Nhập một số và vẽ tam giác số với độ rộng theo bề ngang là một số khác được nhập từ bàn phím.
Ví dụ, với số 4 và độ rộng là 5 thì chúng ta có tam giác:
 
Output : 
4 4 4 4 4
4 4 4 4
4 4 4
4 4
4
 */

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap mot so bat ky :");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap do rong cua tam giac :");
        int width = Convert.ToInt32(Console.ReadLine());
        int height = width;
        for(int i = 0;  i < height; i++)
        {
            for(int j = 0 ; j < width; j++)
            {
                Console.Write(num);
            }
            Console.WriteLine();
            width--;
        }
    }
}