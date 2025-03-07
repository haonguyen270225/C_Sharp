using System.Collections.Generic;
using System;
using System.Runtime.CompilerServices;
using System.Net;
using System.Collections;
/*
 Phương thức TrimExcess() trong List được sử dụng để tối ưu hóa bộ nhớ bằng cách cắt giảm
dung lượng cấp phát dư thừa;
 */
class program
{
    static Random rand = new Random();
    static List<int> list = new List<int>(100); // => Trong List có 100 phân tử;
    static void  Main()
    {
        for( int i = 0; i < 10; i++)
        {
            list.Add(rand.Next() % 100 + 1);
        }
        var n = from s in list
                select s;
        foreach(var item in n)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------------------------------");
        //Trước TrimExcess();
        Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");
        list.TrimExcess();
        Console.WriteLine($"Count: {list.Count}, Capacity: {list.Capacity}");
    }
}

/*
1. TrimExcess() chỉ hoạt động khi có dư thừa bộ nhớ đáng kể
=> Nêu Capacity chỉ lớn hơn Count một chút , nó sẽ không làm gì để tránh tôn tài nguyên
2.Không nên gọi thường xuyên
=>Việt gọi TrimExcess() liên tục (đặc biệt khii thêm / xóa phần tử thường xuyên) có thể gây giảm
hiệu suất , vì mỗi khi dánh sách cần mở rộng , nó phải cấp phát bộ nhớ. 
 */