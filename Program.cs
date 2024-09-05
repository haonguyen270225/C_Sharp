// Tinh tong trung binh cong cua cac phan tu trong mang;
static float tinhTBC(int n, int[] arr)
{
    float kq = 0;
    for (int i = 0; i < n; i++)
    {
        kq += arr[i];
    }
    kq = kq / n;
    return kq;
}
// Tim gia tri max cua cacphan tu trong mang;
static long giaTriMax(int n, int[] arr)
{
    long kq = -10 ^ 4;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] > kq)
        {
            kq = arr[i];
        }
    }
    return kq;
}

//  Tim gia tri cua x trong mang;
static int timViTri(int x, int n, int[] arr)
{
    int vitri = -1;
    for (int i = 0; i < n; i++)
    {
        if (x == arr[i])
        {
            vitri = i;
            break;
        }
    }
    return vitri;
}

Console.Write(" Vui long nhap so luong phan tu trong mang : ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
Random r = new Random();
for (int i = 0; i < n; i++)
{
    arr[i] = r.Next(99) + 1;
}
Console.WriteLine("Gia tri cua cac phan tu trong mang la : ");
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine("\n Ket qua TBC : {0}", tinhTBC(n, arr));
Console.WriteLine(" Gia tri lon nhat trong mang la : {0} ", giaTriMax(n, arr));
int x;
Console.Write("Nhap gia tri ban muon tim trong mang :");
x = int.Parse(Console.ReadLine());
if (x != -1)
{
    Console.WriteLine(" Vi tri phan tu ban can tim la : {0} ", timViTri(x, n, arr) + 1);
}
else Console.WriteLine(" Khong tim thay gia tri ban can tim !");