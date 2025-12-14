using Variable;
using CSharp_Basic.OOP;
using System.Text;
using LearnTryCatch;
using System;
using CSharp_Basic.Generic_Class_And_Methods;
namespace CSharp_Basic
{
    internal class Program
    {
        static void  Method_Generic()
        {
            GenericList<int> list = new();
            list.Add(1);

            GenericList<string> list2 = new();
            list2.Add("");

            GenericList<ExampleClass> list3 = new();
            list3.Add(new ExampleClass());
        }
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.UTF8;

            Method_Generic();
            
        }
    }
}
