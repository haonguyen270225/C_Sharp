using System.ComponentModel.Design;

class Program
{
    // Demo thuật toán xắp sếp chọn (Selection Sort !);
    //Input:  [5, 2, 8, 1, 9]
    //Output: [1, 2, 5, 8, 9]

    //Input:  [1, 2, 3, 4, 5]
    //Output: [1, 2, 3, 4, 5]

    //Input:  [9, 8, 7, 6, 5]
    //Output: [5, 6, 7, 8, 9]

    //Input:  []
    //Output: []

    //Input:  [4, 2, 4, 1, 2]
    //Output: [1, 2, 2, 4, 4]

    //Input:  [7]
    //Output: [7]

    //Input:  [-3, 5, -1, 0, 2]
    //Output: [-3, -1, 0, 2, 5]

    //Input:  [64, 25, 12, 22, 11]
    //Output: [11, 12, 22, 25, 64]

    static void Swap( ref int i , ref int j)
    {
        int temp = i;
        i = j;
        j = temp;
        
    }
    static void Selection_Sort(int []a)
    {
        int n = a.Length;
        if (n == 0 || n == 1)
        {
            return;
        }
        else
        {
            for(int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[min_idx]) 
                    {
                        min_idx = j;
                    }
                }
                Swap( ref a[i] , ref a[min_idx]);
            }
        }
    }

    static void Prin_Arr(int[] a)
    {
        if (a.Length == 0)
        {
            Console.WriteLine("[ ]");
            return;
        }
        else if (a.Length == 1) 
        {
            Console.WriteLine("[ " + a[0] + " ]");
            return;
        }
        else
        {
            Console.Write("[ ");
            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1)
                {
                    Console.Write(a[i]);
                }
                else
                {
                    Console.Write(a[i] + ",");
                }
                
            }
            Console.Write(" ]\n");
        }
        
    }
    private static int Main()
    {
        int []a = [5, 2, 8, 1, 9];
        int []b = [1, 2, 3, 4, 5];
        int []c = [9, 8, 7, 6, 5];
        int []d = [];
        int []e = [4, 2, 4, 1, 2];
        int []f = [7];
        int []g = [-3, 5, -1, 0, 2];
        int []h = [64, 25, 12, 22, 11];

        // Gọi hàm sắp xếp chọn :
        Selection_Sort(a);
        Selection_Sort(b);
        Selection_Sort(c);
        Selection_Sort(d);
        Selection_Sort(e);
        Selection_Sort(f);
        Selection_Sort(g);
        Selection_Sort(h);
        Prin_Arr(a);
        Prin_Arr(b);
        Prin_Arr(c);
        Prin_Arr(d);
        Prin_Arr(e);
        Prin_Arr(f);
        Prin_Arr(g);
        Prin_Arr(h);
        return 0;
    }
}
