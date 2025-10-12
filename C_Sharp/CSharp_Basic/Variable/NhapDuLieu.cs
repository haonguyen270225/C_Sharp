namespace Variable
{
    public class NhapDuLieu
    {
        public void DemoNhapDuLieu()
        {
            int i;
            float f;
            string s;
            double d;
            char c;

            Console.WriteLine("Nhap ten cua ban !");
            s = Console.ReadLine();
            Console.WriteLine("Ten cua ban vua nhap la :" + s);
            Console.WriteLine("Nhap tuoi cua ban : ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("Tuoi cua ban la : " + i);

            Console.WriteLine("Nhap ki tu tu ban phim : ");
            c = char.Parse(Console.ReadLine());
            Console.WriteLine("Ki tu ban vau nhap la : " + c);
            Console.WriteLine("Nhap gia tri float : ");
            f = float.Parse(Console.ReadLine());
            Console.WriteLine("Gia tri float ban vua nhap la :" + f);
            
        }

    }

}
