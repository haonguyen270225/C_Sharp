using System.CodeDom.Compiler;
class program
{
    static void Main()
    {
        Random rand = new Random();
        List<int> list = new List<int>();
        for( int i = 0; i < 30; i++)
        {
            list.Add(rand.Next() % 100 + 1);
        }
        Console.WriteLine("\nDanh sach truoc khi xap sep la : ");
        foreach (var item in list)
        {
            Console.Write(" ");
            Console.Write(item);
        }
        list.Sort();
        Console.WriteLine("\nDanh sach sau khi xap sep la : ");
        foreach (var item in list)
        {
            Console.Write(" ");
            Console.Write(item);
        }
    }
    
}