﻿///Tính đa hình trong C# (polymorphism);
/// <summary>
/// 1-Đa hình động (đa hình dynamic)
/// Sử dụng từ khóa  virtual trước phương thức ảo  của lớp cha (base class) để thể hiện phương thức có thể ghi đè
/// Sử dụng từ khóa override đánh trước phương thức của lớp con (devived class) để thể hiện phương thức ghi đè
/// Chỉ có thể ghi đè lên phương thức virtual và abstract
/// 
/// 2-Đa hình tĩnh (đa hình static)
/// -Nạp chồng hàm (Function overloading)
/// -Nạp chồng toán tử (Operator overloading)
/// </summary>
/// 




class Animal
{
    virtual public  void  Speak()
    {
        Console.WriteLine("Animal is speaking......... ");
    }
}

class Cat : Animal
{
    override public  void Speak()
    {
        Console.WriteLine("Cat is speaking.........");
    }
}


class Dog : Animal
{
    override public  void Speak()
    {
        Console.WriteLine("Dog is speaking..........");
    }
}
class Program
{
    static void Main()
    {
        Animal cat = new Cat();
        Animal dog = new Dog();
        cat.Speak();
        dog.Speak();
    }
}