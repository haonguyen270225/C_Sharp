using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Option1
{
    public class Person_Class(string name , int age)
    {
        public string Name {  get; set; } = name;
        public int Age {  get; set; } = age;
        //Other properties , methods , event , ....
        // -> Class là kiểu tham chiếu (Reference Type) -> được quản lý trên vùng nhớ Heap;
        // Mõi đối tượng được tạo ra từ Class sẽ có một địa chỉ riêng biệt trên Heap;
        // Khi đối tượng thứ hai được tạo ra từ Class thì nó sẽ có một địa chỉ khác biệt so với đối tượng thứ nhất;
        // Nhưng nếu ta gán đối tượng thứ hai = đối tượng thứ nhất thì cả hai sẽ cùng trỏ đến một địa chỉ trên Heap;
    }

    //static void Main(string[] args)
    //   {
    //       Person_Class person1 = new("Lono", 10);
    //       Console.WriteLine($"person1 Name =  {person1.Name} , Age = {person1.Age}");

    //       // Tạo person2 là thể hiện của  lớp Person , gán gía trị từ person1;
    //       Person_Class person2 = person1;
    //       person2.Name = "Nami";
    //       person2.Age = 20;
    //       Console.WriteLine($"person2 Name = {person2.Name} , Age = {person2.Age}");
    //       Console.WriteLine($"person1 Name = {person1.Name} , Age = {person1.Age}");
    //       /* Output :
    //           person1 Name =  Lono , Age = 10
    //           person2 Name = Nami , Age = 20
    //           person1 Name = Nami , Age = 20
    //        */
    //   }


    public struct Person_struct
    {
        public string Name;
        public int Age;


        public Person_struct(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        // Struct là kiểu giá trị (Value Type) -> được quản lý trên vùng nhớ Stack;
        // Mỗi đối tượng được tạo ra từ Struct sẽ có một vùng nhớ riêng biệt trên Stack;
        // Khi đối tượng thứ hai được tạo ra từ Struct thì nó sẽ có một vùng nhớ khác biệt so với đối tượng thứ nhất;
        // Nếu ta gán đối tượng thứ hai = đối tượng thứ nhất thì cả hai sẽ có hai vùng nhớ riêng biệt trên Stack;



        //static void Main(string[] args)
        //{
        //    // Tạo một thể hiện của struct và khởi tạo nó bằng toán tư  new;
        //    // Bộ nhớ được cấp phát trên Stack;
        //    Person_struct person1 = new("Luffy", 19);
        //    Console.WriteLine($"person1 Name = {person1.Name} , Age = {person1.Age}");

        //    // Khởi tạo person2 , gán giá trị từ person1;
        //    Person_struct person2 = person1;
        //    person2.Name = "Zoro";
        //    person2.Age = 21;
        //    Console.WriteLine($"person2 Name = {person2.Name} , Age = {person2.Age}");
        //    Console.WriteLine($"person1 Name = {person1.Name} , Age = {person1.Age}");

        //    /* Output:
        //     person1 Name = Luffy , Age = 19
        //     person2 Name = Zoro , Age = 21
        //     person1 Name = Luffy , Age = 19
        //     */
        //}
    }
}
