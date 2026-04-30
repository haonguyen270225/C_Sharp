// Bài tập kiểm tra xem các mảng có hoặc tập hợp có
// rời rạc nhau không.
/*
 Cho hai mảng a[] và b[] , kiểm tra xem hai mảng có rời nhau hay không , 
nghĩa là chúng có phần tử nào chung hay không.
-------
Đầu vào : a[] = [12, 34, 11, 9, 3], b[] = [2, 1, 3, 5] 
Đầu ra : Sai 
Giải thích : Số 3 xuất hiện chung trong cả hai mảng.
-------
Đầu vào : a[] = [12, 34, 11, 9, 3], b[] = [7, 2, 1, 5] 
Đầu ra : True 
Giải thích : Không có phần tử chung nào trong cả hai mảng.
 */

// CÁCH 1 : sử dụng hai vòng lập lòng nhau:
// Thời gian O(n*m) không gian O(1)

using System;
using System.Collections.Generic;


static bool AreDisjoint_0(int[] a, int[] b)
{
    for(int i = 0; i < a.Length; i++)
    {
        for(int j = 0; j < b.Length; j++)
        {
            if (a[i] == b[j])
            {
                return false;
            }
        }
    }
    return true;
}
// CÁCH 2 : Sử dụng thuật toán sắp xếp và hai con trỏ. Thời gian O(nlogn + mlogm),không gian O(1)
static bool AreDisjoint_1(int[] a, int[] b)
{
    // Sắp xếp cả hai mảng !.
    Array.Sort(a);
    Array.Sort(b);
    int i, j;
    i = 0; j = 0;
    // Khởi tạo con trỏ tại phần đầu của hai mảng.
    while (i < a.Length && j < b.Length)
    {
        // Nếu tìm thấy phần tử chung thì cả hai mảng không rời nhau.
        if (a[i] == b[j])
        {
            return false;
        }

        // Tăng con trỏ có giá trị nhỏ hơn.
        if (a[i] < b[j])
        {
            ++i;
        }
        else
        {
            ++j;
        }
    }
    return true;
}

// CÁCH 3 : Sử dụng Hasing. Với thời gian O(n+m) - không gian O(1)
/*
 Đầu tiên, ta chèn các phần tử của mảng a vào một tập hợp băm. Sau đó với mỗi phần tử của mảng b
ta kiểm tra xem nó có trong tập hợp băm hay không. Nếu bất kỳ phần tử nào trong mảng b được
tìm thấy trong tập hợp băm, thì cả hai mảng không rời nhau ngược lại chúng rời nhau.
 */

static bool AreDisjoint_2(int[] a , int[] b)
{
    HashSet<int> set_a = new HashSet<int>();
    
    // Chèn tất cả các phần tử của mảng vào hàm băm.
    foreach(int i in a)
    {
        set_a.Add(i);
    }

    foreach(int i in b)
    {
        if (set_a.Contains(i))
        {
            return false;
        }
    }
    return true;
}
static void Main()
{
    int[] a_1 = { 12, 34, 11, 9, 3 };
    int[] b_1 = { 2, 1, 3, 5 };
    int[] a_2 = { 12, 34, 11, 9, 3 };
    int[] b_2 = { 7, 2, 1, 5 };
    Console.WriteLine("Su dụng hai vòng lặp lòng nhau : \n");
    if(AreDisjoint_0(a_1 , b_1))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }

}

