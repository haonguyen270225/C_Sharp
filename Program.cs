using System.Text;
Console.OutputEncoding = Encoding.UTF8;
SinhVien sv = new SinhVien("Hào", "Kiên Giang", "123hg", 8.9);
Console.WriteLine(sv.toString());
public class Nguoi
{
    // thuoc tinh;
    protected string hoten;
    protected string diatri;
    // phuong thuc;
    // ham khoi tao khong doi so;
    public Nguoi() { }

    // ham khoi tao co doi so;
    public Nguoi(string hoten , string diatri)
    {
        this.hoten = hoten;
        this.diatri = diatri;
    }
    public string getHoTen()
    {
        return hoten;
    }
    public string getDiaTri()
    {
        return diatri;
    }
    // ham nhan gia tri ve dia tri;
    public void setDiaTri(string diatri)
    {
        this.diatri = diatri;
    }
    
    // Ham hien thi thong tin co ban cua 1 nguoi;
    public string toString()
    {
        return "Thong tin : " + hoten + "-" + diatri;
    } 
}


public class SinhVien : Nguoi
{
    // thuoc tinh;
    private string masv;
    private double diemtbc;

    // phuong thuc;

    // ham khoi tao khong doi so;
    public SinhVien() { }

    // ham khoi tao co tham so;
    public SinhVien(string hoten , string diatri , string masv , double diemtbc) : base(hoten , diatri )
    {
        this.masv = masv;
        this.diemtbc = diemtbc;
    }
    // Ham hien thi thong tin co ban cua sinh vien;
    public string toString()
    {
        return "Thong tin sinh vien : " + hoten + "-" + diatri + "-" + masv + "-" + diemtbc;
    }
}

