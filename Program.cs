using System.Data;

int[] arr = new int[10];
int i;
Console.Write("Nhap so luong phan tu trong mang : ");
int n = int.Parse(Console.ReadLine());
for( i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Mang vua nhap la : ");
for( i = 0; i < n; i++)
{
    Console.Write(arr[i] + "\t");
}
i = 0 ;

for( i = 0; i < n; i++)
{
    if (arr[i] == 0)
    {
        for( int j = i; j < n - 1; j++)
        {
            arr[j] = arr[j + 1];
        }
        --n;
        --i;
    } 
}
Console.WriteLine("\n\tMang sau khi loc la : ");
for (i = 0; i < n; i++)
{

    Console.Write(arr[i] + "\t");
}
/*// Xoa phan tu co gia tri la 0;
for ( i = 0; i < n; i++)
{
    if (arr[0] == 0)
    {
        for( int j = 0; j < n-1; j++)
        {
            arr[j] = arr[j + 1];
        }
        --n;
    }
    for(int j = i; j < n; j++)
    {
        if (arr[j] == 0)
        {
            for( int k = j; k < n - 1 ; k++)
            {
                arr[k] = arr[k + 1];
            }
            --n;
        }
    }
}

Console.WriteLine("\n\tMang sau khi loc la : ");
for( i = 0; i < n; i++)
{

    Console.Write(arr[i] + "\t");
}*/
// Tach mang thanh hai mang : 1 mangr chi chua phan tu gia tri am , 1 mang chi chua phan tu gia tri duong;
int m1 = 0, m2 = 0;// m1 chi so cua mang duong , m2 chi so cua mang am;
int[] b = new int[10];// mang chua cac phan tu duong;
int[] c = new int[10];// mang chua cac phan tu am;
for( i = 0; i < n; i++)
{
    if (arr[i] > 0)
    {
        b[m1] = arr[i];
        ++m1;
    }
    else
    {
        c[m2] = arr[i];
        ++m2;
    }
}
Console.WriteLine("\n\tMang chua cac phan tu am la : ");
for( i = 0; i < m2; i++)
{
    Console.Write(c[i] +  "\t");
}
Console.WriteLine("\n\tMang chua cac phan tu duong la : ");
for (i = 0; i < m1; i++)
{
    Console.Write(b[i] + "\t");
}

