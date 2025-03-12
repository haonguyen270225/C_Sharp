///Tính đa hình trong C# (polymorphism);
///<summary>
/// Lớp trừu tượng và phương thức thuần ảo
/// Phương thức thuần ảo là phương thức không có định nghĩa bên trong;
/// Lớp trừu tượng là lớp chứa phương thức thuần ảo.
/// abstract là từ khóa dùng để khai báo một lớp trừu tượng và một phương thức thuần ảo.
/// </summary>


// => Khi sử dụng từ khóa override để ghi đề lên phương thức lớp cha có chứa từ khóa virtual .
// => Việt định nghĩa phương thức của lớp cha là không cần thiết .
// => abstract nhấn mạnh 2  điều:
// 1- là phương thức  bị ghi đè (override)
// 2- Phương thức không cần định nghĩa.
//
//Lớp trừu tượng có các đặc điểm sau:
// Muốn kế thừa lớp trừu tượng bạn buộc phải override lại tất cả các phương thức thuần ảo nhằm đảm bảo tính hợp lệ của chương trình
//=>

abstract class Animal
{
     public abstract void Speak();
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