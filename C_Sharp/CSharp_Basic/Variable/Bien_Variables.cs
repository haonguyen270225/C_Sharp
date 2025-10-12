namespace Variable
{
    public class KhaiBao_Bien
    {
        public void KhaiBaoBien()
        {
            // Các biến trong C# : int , char , float , string
            
            // Khai báo :
            int x, y;
            float z;
            char k;
            double h;
            string m;

            // Khai báo và gán :
            int i = 0;
            char c = 'a';
            float f = 12.12f;
            double d = 12.02;
            string s = "Nguyen Van A";

            Console.WriteLine(i);
            Console.WriteLine(c);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(s);

            Console.WriteLine("Gia tri la :" + i);
            Console.WriteLine("Gia tri la :" + c);
            Console.WriteLine("Gia tri la :" + f);
            Console.WriteLine("Gia tri la :" + d);
            Console.WriteLine("Gia tri la :" + s);
            Console.WriteLine("Gia tri la :" + s + "aa?");


            //Các kiểu dữ liệu : sbyte , short , long , byte , ushort , uint , ulong

            sbyte sb = 10; // -128 to 127;
            short sh = 20; // -32768 to 32767
            long l = 20000; // -2^31 to 2^31 - 1
            byte by = 0; // -2^64 to 2^63 - 1
            ushort us = 20;// 0 to 65535;
            uint ui = 100; // 0 to 2^32;
            ulong ul = 0; // 0 to 2^63;

            Console.WriteLine("Gia Tri la sbyte : " + sb);
            Console.WriteLine("Gia Tri la short : " + sh);
            Console.WriteLine("Gia Tri la long : " + l);
            Console.WriteLine("Gia Tri la byte : " + by);
            Console.WriteLine("Gia Tri la ushort : " + us);
            Console.WriteLine("Gia Tri la uint : " + ui);
            Console.WriteLine("Gia Tri la ulong : " + ul);
        }
    }
}