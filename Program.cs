
using System.Net.Http.Headers;

PS ps1 = new PS( 1 , 2);
PS ps2 = new PS(2, 4);
PS pstong = new PS();
Console.WriteLine("Nhap vao phan so thu 1 : ");
ps1.Nhap();
Console.WriteLine("Nhap vao phan soi thu 2 :");
ps2.Nhap();
ps1.Xuat();
ps2.Xuat();
ps1.rutGonPS();
ps1.Xuat();
ps2.rutGonPS();
ps2.Xuat();
pstong = ps1.tinhTongPS(ps2);
pstong.Xuat();
public class PS
{   
    // Thuoc tinh;
    private int ts;
    private int ms;
    // phuong thuc
    
    // ham hoi tao khong doi so;
    public PS() {
        ts = 0;
        ms = 1;
    }

    // ham khoi tao co doi so;
    public PS( int ts , int ms)
    {
        this.ts = ts;
        this.ms =  ms;
    }

    // Ham nhap;
    public void Nhap( )
    {
        do
        {
            int ts;
            int ms;
            Console.Write("Nhap tu so : ");
            ts = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so : ");
            ms = int.Parse(Console.ReadLine());
            if (ms == 0)
            {
                Console.WriteLine(" Mu so khong hop le ! , (Nhap lai) : ");
            }
            else
            {
                this.ts = ts;
                this.ms = ms;
            }
        } while (ms == 0);
    }
    
    // Ham hien thi phan so;
    public void Xuat()
    {
        if(this.ts * this.ms < 0)
        {
            Console.WriteLine("-" + Math.Abs(this.ts) + "/" + Math.Abs(this.ms));
        }
        else
        {
            Console.WriteLine(Math.Abs(this.ts) + "/" + Math.Abs(this.ms));
        }
    }
    // ham tim uoc so chung lon nhat;
    private int UCLN( int a , int b)
    {
        int r = a % b;
        while( r != 0)
        {
            a = b;
            b = r;
            r = a % b;
        }
        return b;
    }
    // Ham rut gon phan so;
    public void rutGonPS()
    {
        int x = UCLN(ts, ms);
        ts /= x;
        ms /= x;
    }
    
    // ham tinh tong hai phan so;
    public PS tinhTongPS(PS ps2)
    {
        int mau = ts * ps2.ms + ps2.ms * ts;

        int tu = ms * ps2.ms;

        return new PS(tu, mau);
    }
}
