using System;
class Program
{
    static void Main(string[] args)
    {
        char char1, char2, char3;
        Console.Write("Nhap chu cai thu nhat :");
        char1 = Convert.ToChar(Console.ReadLine());

        Console.Write("Nhap chu cai thu hai :");
        char2 = Convert.ToChar(Console.ReadLine());

        Console.Write("Nhap chu cai thu ba :");
        char3 = Convert.ToChar(Console.ReadLine());

        Console.Write("Hien thi 3 chu cai theo chieu nguoc lai : ");
        Console.WriteLine("{0} {1} {2}",char3 , char2 , char1);
    }
}

