namespace Chuong3
{
    class Bai1
    {
        private string[] name = ["Spencer", "Sally", "Doug"];
        public string GetName(int ID)
        {
            if(ID < name.Length)
            {
                return name[ID];
            }
            else
            {
                return string.Empty;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bai1 bai1 = new Bai1();
            Console.WriteLine($"{bai1.GetName(0)}");
            Console.WriteLine($"{bai1.GetName(5)}");
        }
    }
}
