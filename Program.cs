float[] arr = new float[100];
Console.Write(" So luong phan tu trong mang la : ");
int n = int.Parse(Console.ReadLine());
//Random rd = new Random();
for ( int i = 0; i < n; i++  )
{
    //arr[i] = (float)Math.Round((float)rd.Next(99)/(i+2) , 2);
    // Lam tron den 2 chu so thap phan;
    arr[i] = float.Parse(Console.ReadLine());
}
Console.WriteLine("\n\t Gia tri cua cac phan tu trong mang la : ");
for( int i = 0; i < n; i++)
{
    Console.Write(arr[i] + "\t");
}
// sap xep day  theo chieu tang dan;
for( int i = 0; i < n-1; i++)
{
    for( int j = i+ 1; j < n; j++)
    {
        if (arr[i] > arr[j])
        {
            float tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
    }
}
Console.WriteLine("\n\t Mang sau khi duoc xap sep la : ");
for( int i = 0; i < n; i++)
{
    Console.Write(arr[i] + "\t");
}

int k = n;
// Loai bo cac phan tu trung nhau;
for( int i = 0; i < n - 1; i++)
{
    if (arr[i] == arr[i + 1])
    {
        for( int j = i; j < n; j++)
        {
            arr[j] = arr[j + 1];
        }
        --n;
    }
}

Console.WriteLine("\n\t Mang sau khi loai bo cac phan tu trung nhau la : ");
for( int i = 0; i < n; i++)
{
    Console.Write(arr[i] + "\t");
}
// Bo sung x vao day sao cho day van la day tang dan:
Console.WriteLine("\n\t Gia tri ma ban muon them vao la : ");
float x = float.Parse(Console.ReadLine());

for( int i = 0; i < n;i++)
{
    if (arr[i] > x )
    {
        for( int j = n ; j > i ; j--)
        {
            arr[j] = arr[j - 1];
        }
        arr[i] = x;
        n++;
        break;
    }
    if (arr[n-1] < x)
    {
        arr[n] = x;
        ++n;
    }
}
Console.WriteLine("\n\t Mang cua ban sau khi them x la : ");
for ( int i = 0; i < n; i++)
{
    Console.Write(arr[i] + "\t");
}