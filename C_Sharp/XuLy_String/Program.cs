class Program
{

    /*Khai báo chuỗi trong C#*/
    static void String_B1()
    {
        string str1 = "Hello world !_1";
        string str2 = "Hello world !_2";
        Console.WriteLine("Chuỗi ký tự 1 : " + str1); Console.WriteLine("Chuỗi ký tự 2 : " + str2);
    }

    /*string.Length : Độ dài chuỗi !*/
    static int String_B2(string str)
    {
        return str.Length;
    }
    static void Main()
    {
        // String in C# !
        String_B1();

        // Độ dài chuỗi !
        Console.WriteLine(String_B2("12345_str"));
        

    }
}