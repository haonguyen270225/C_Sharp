
using System;
using OOP.Option1;
class Program
{
    static void Main(string[] args)
    {
        // Tạo một thể hiện của struct và khởi tạo nó bằng toán tư  new;
        // Bộ nhớ được cấp phát trên Stack;
        Person_struct person1 = new("Luffy", 19);
        Console.WriteLine($"person1 Name = {person1.Name} , Age = {person1.Age}");

        // Khởi tạo person2 , gán giá trị từ person1;
        Person_struct person2 = person1;
        person2.Name = "Zoro";
        person2.Age = 21;
        Console.WriteLine($"person2 Name = {person2.Name} , Age = {person2.Age}");
        Console.WriteLine($"person1 Name = {person1.Name} , Age = {person1.Age}");

        /* Output:
         person1 Name = Luffy , Age = 19
         person2 Name = Zoro , Age = 21
         person1 Name = Luffy , Age = 19
         */
    }
}   