int n;
Console.Write("Nhap so luong phan tu trong mang : ");
n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int i;
for (i = 0; i < n; i++)
{
    Console.Write("\t Nhap phan tu thu {0} : ", i + 1);
    int x = int.Parse(Console.ReadLine());
    arr[i] = x;
}
 Console.WriteLine(" Gia tri cua cac phan tu trong mang la : ");
Console.Write("\t");
for (i = 0; i < n; i++)
{
    Console.Write(arr[i] + "\t");
}

// Kiem tra day so co phai la day tang dan hay khong;
int check = 1;
for( i = 0; i < n - 1 ; i++)
{
    if (arr[i] > arr[i + 1])
    {
        check = 0;
        break;
    }
}
if( check == 1)
{
    Console.WriteLine("\n\t Day so cua ban la day tang dan !");
}
else
{
    Console.WriteLine("\n\t Day so cua ban khong la day tang dan !");
}

// Kiem tra day so co tao thanh cap so cong hay khong;

check = 1;
int k = arr[1] - arr[0]; 
for( i = 0; i < n - 1; i++)
{
    if (k != arr[i + 1] - arr[i])
    {
        check = 0;
        break;
    }
}
if (check == 1)
{
    Console.WriteLine("\n\t Day so cua ban la day cap so cong  !");
}
else
{
    Console.WriteLine("\n\t Day so cua ban khong la day cap so cong !");
}

// c : Kiem tra xem day co phai la day doi xung hay khong;
check = 1;
i  = 0;
int j  = n - 1;
while (i < j )
{
    if (arr[i] == arr[j])
    {
        ++i;
        --j;
    }
    else
    {
        check = 0;
        break;
    }
}

if (check == 1)
{
    Console.WriteLine("\n\t Day so cua ban la day doi xung  !");
}
else
{
    Console.WriteLine("\n\t Day so cua ban khong la day doi xung !");
}
