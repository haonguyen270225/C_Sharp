
/*
 bool myList.TrueForAll(Predicate<T> match)
=> Predicate<T> (hàm điều kiện) để kiểm tra từng phần tử trong danh sách
Trả về:
true : Nếu tất cả các phần tử trong danh sách thảo mãn điều kiện
flase:Nếu ít nhất môt phần tử khồng thỏa mãn điều kiện.
 */
class Program
{
    static void Main()
    {
         Random random = new Random();
         List<int> list = new List<int>(20);
        for (int i = 0; i < 20; i++)
        {
            list.Add(random.Next() % 100 + 1 );
        }

        Console.WriteLine("Danh sach cac phan tu trong List la : ");
        foreach(int i in list)
        {
            Console.WriteLine(i);
        }
        // Kiểm tra tất cả số trong danh sách có phải là số chẵn không ?
        bool check1 = list.TrueForAll(x => x % 2 == 0);
        Console.WriteLine("Tat cac cac so trong danh sach co phai la so chan khong? {0}" , check1);

        //Kiểm tra tất cả sô trong danh sách có phải nho hơn 100 không ?
        bool check2 = list.TrueForAll(x => x < 100);
        Console.WriteLine("Tat cac cac so trong danh sach co phai nho  hon 100 khong? {0}", check2);
    }
}