using System;
namespace CSharp_Basic
{
    internal class Program
    {
        /*Khai báo một Generic cơ bản !*/
        public class GenericClass<T>
        {
            public  void Add(T item){}
        }
        public class Example{}

        /*Sử dụng Generic như lớp danh sách kiểu generic đơn giản ! */
        public class GenericList_1<T>
        {
            // 1 Lớp lồng nhau trong Generic 
            private class  Node(T t) // Nhận tham số kiểu T
            {
                public T Data { get; set; } = t; /*Data kiểu T để lưu trữ dữ liệu !*/
                public Node? Next { get; set; } /*Next con trỏ đến Node tiếp theo !*/

            }
            private Node head; /*Phần tử đầu tiên của danh sách liên kết !*/
            public void AddHead(T t)
            {
                Node n = new(t);
                n.Next = head;
                head = n;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lớp và phương thức trong genric !");
            // Danh sách Generic kiểu int;
            GenericClass<int> genericInt = new GenericClass<int>();
            genericInt.Add(123);
            // Danh sách Generic kiểu string;
            GenericClass<string> genericString = new GenericClass<string>();
            genericString.Add("Hello Generic !");
            // Danh sách Generic kiểu Example;
            GenericClass<Example> genericExample = new GenericClass<Example>(); 
            genericExample.Add(new Example());

        }
    }
}
