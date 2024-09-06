int[] arr = new int[10];
int n;
Console.Write("Nhap so luong phan tu trong mang : ");
n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    Console.Write("\tVui long nhap phan tu thu {0} :", i + 1);
    arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine(" Gia tri cua cac phan tu trong mang la : ");
for( int i = 0; i < n; i++)
{
    Console.Write(arr[i] + "\t");
}

// Chen them 1 gia tri x vao vi tri m;
Console.Write("\n\tNhap gia tri ban muon chen : ");
int x = int.Parse(Console.ReadLine());
Console.Write("\tVi tri ban can chen la : ");
int m = int.Parse(Console.ReadLine());

for(int i = n; i >=  m; i--)
{
    arr[i] = arr[i - 1];
}
++n;
arr[m - 1] = x;

Console.WriteLine("\n\tMang cua sau khi chen la :");
for( int i = 0; i < n; i++)
{
    Console.Write(arr[i] + "\t");
}


// Sua gia tri nam o vi tri k thanh gia tri moi y;
Console.Write("\n\tNhap gia tri ban muon sua : ");
int y = int.Parse(Console.ReadLine());
Console.Write("\tVi tri ban can sua la : ");
int k = int.Parse(Console.ReadLine());
arr[k - 1] = y;
Console.WriteLine("\t Mang cua ban sau khi sua la : ");
for( int i = 0; i < n; i++)
{
    Console.Write(arr[i] + "\t");
}

// Xoa phan tu nam o vi tri q;
Console.Write("\n\t Vi tri phan tu ban muon xoa la : ");
int q = int.Parse(Console.ReadLine());
for( int i = q - 1; i < n; i++)
{
    arr[i] = arr[i + 1];
}
--n;
Console.WriteLine("\n\t Mang cua ban sau khi xoa la : ");
for(int i = 0; i < n; i++)
{
    Console.Write(arr[i] + "\t");
}
Console.WriteLine("\n==============================================");
Console.ReadLine();