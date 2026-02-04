//using Variable;
using CSharp_Basic.OOP;
using System.Text;
using LearnTryCatch;
using System;
using CSharp_Basic.Generic_Class_And_Methods;
using GreeksForGeeks;
using CSharp_Basic.LearnString;
namespace CSharp_Basic
{
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.UTF8;
            ChuanHoaChuoi chuanHoaChuoi = new ChuanHoaChuoi();
            chuanHoaChuoi.Nhap_ChuanHoaChuoi();
            while(chuanHoaChuoi.Check_Ten(chuanHoaChuoi.strChuanHoa) == false)
            {
                chuanHoaChuoi.Nhap_ChuanHoaChuoi();
            }
            chuanHoaChuoi.ChuanHoa();
            chuanHoaChuoi.Xuat_ChuanHoaChuoi();
            
        }
    }
}
