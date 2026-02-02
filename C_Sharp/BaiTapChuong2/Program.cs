using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
namespace BaiTapChuong2
{
    internal class Program
    {
        public static void Bai21()
        {
            Console.WriteLine("\t ---- Tính delta ! ----");
            int a = 0, b = 0, c = 0;
            Console.Write("Nhập a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập c : ");
            c = Convert.ToInt32(Console.ReadLine());
            int delta = b * b - 4 * a * c;
            Console.WriteLine("- delte = {0} * {1} - 4 * {2} * {3}\n" , b , b , a , c);
            Console.WriteLine($"Kết quả delta là : {delta} \n");
        }

        public static void Bai22()
        {
            Console.WriteLine("\t---- Giải phương trình ax^2 + bx + c = 0 ----");
            double a = 0, b = 0, c = 0;
            double delta = 0;
            Console.Write("Nhập a : ");
            a = Convert.ToDouble(Console.ReadLine());
            do // Kiểm tra biến a != 0;
            {
                if (a == 0)
                {
                    Console.WriteLine("a không hợp lệ (a !=0 )!");
                    Console.Write("Nhập a : ");
                    a = Convert.ToDouble(Console.ReadLine());
                }
            } while (a == 0);
            Console.Write("Nhập b : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập c : ");
            c = Convert.ToDouble(Console.ReadLine());
            delta = b * b - 4 * a * c;

            if(delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm !");
            }
            else
            {
                if(delta == 0)
                {
                    double x = 0;
                    x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {x}" , x);
                }
                else
                {
                    double x1 = 0, x2 = 0;
                    x1 = (-b -  Math.Sqrt(delta)) / (2*a);
                    x2 = (-b  + Math.Sqrt(delta))/ (2 * a);
                    Console.WriteLine("Phương trình có hai nghiệm : \n");
                    Console.Write($"x1 = {x1}\n");
                    Console.Write($"x1 = {x2}\n");
                }
            }
        }
        public static double GiaiThua(int n)
        {
            double gt = 1;
            for (int i = 1; i <= n; i++)
                gt *= i;
            return gt;
        }

        public static void Bai23()
        {
            double s1 = 0 , s2 = 0 , s3 = 0 , s4 = 0 , s5 = 0 ;
            //int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t---- Tính s1 !----");
            for(int i = 0; i <= 100; i++)
            {
                s1 += (double)i / (i * i + 1);
            }
            Console.WriteLine($"s1 = {s1}");

            Console.WriteLine("\t---- Tính s2 !----");
            Console.Write("Nhập n = ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n2 ; i++)
            {
                s2 += (double)i / (i + 1);
            }
            Console.WriteLine($"s2 = {s2}");

            Console.WriteLine("\t---- Tính s3 !----");
            Console.Write("Nhập n = ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n3 ; i++)
            {
                double giaiThua = 1.0;
                for(int j = 1; j <= i; j++)
                {
                    giaiThua *= (double)j;
                }
                s3 += giaiThua/i;
            }
            Console.WriteLine($"s3 = {s3}");

            Console.WriteLine("\t---- Tính s4 !----");
            Console.Write("Nhập x = ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int k = 1; k <= n; k++)
            {
                int soLe = 2 * k - 1;       // 1, 3, 5, ...
                double tu = GiaiThua(soLe); // (2k - 1)!
                double mau = x + soLe;      // x + (2k - 1)
                s4 += tu / mau;
            }
            Console.WriteLine($"S4 = {s4}");

            Console.WriteLine("\t---- Tính s5 !----");
            Console.Write("Nhập n = ");
            int n5 = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n5; i++)
            {
                int k = i * i;
                double giaiThua = 1.0;
                for(int j = 1; j < k; j++)
                {
                    giaiThua *= (double)j;
                }
                s5 += Math.Pow(k, giaiThua);
            }

            Console.WriteLine($"s5 = {s5}");
        }

        
        public static void Bai24()
        {
            double m = 0;
            int n = 0;
            Console.WriteLine("\t---- Mảng 1 chiều ----");
            Console.WriteLine("\t----- Nhập n số thực ----");
            Console.Write("Nhập mảng 1 chiều : ");
            n = Convert.ToInt32(Console.ReadLine());

            do
            {
                if(n <= 0)
                {
                    Console.WriteLine("N không hợp lệ (n > 0) !");
                    Console.Write("Nhập n = ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
            } while (n <= 0);
            double[] myArr = new double[n];
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write("arr[{0}] = ", i + 1);
                myArr[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("\t----- Hiển thị n số thực ! ----");
            foreach (var item in myArr)
            {
                Console.Write("{0}  " ,item);
            }

            Console.WriteLine("\t\n----- Hiển thị số thực lớn nhất trong dẫy và nhỏ hơn m ----");
            Console.Write("Nhập m : ");
            m = Convert.ToDouble(Console.ReadLine());
            double kp = -100000.0;
            foreach (var item in myArr)
            {
                if(item < m && kp < item)
                {
                    kp = item;
                }
            }
            if(kp == -100000.0)
            {
                Console.WriteLine("Dãy không có số nhỏ hơn m !\n");
            }
            else
            {
                Console.WriteLine("Kết quả = {0}", kp);
            }

            Console.WriteLine("\t\n----- Xóa các phần tử bằng m ! ----");
            Console.Write("Nhập m : ");
            m = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < n; i++)
            {
                if (myArr[i] == m)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Không có số bằng m !");
            }
            else
            {
                for (int i = 0; i < n; i++) {
                    if (myArr[i] == m)
                    {
                        for (int j = i; j < n - 1; j++)
                        {
                            myArr[j] = myArr[j + 1];
                        }
                        n--;
                        i--;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0}  ", myArr[i]);
                }
            }

            Console.WriteLine("\n\t---- Xắp sếp số giảm dần ----- ");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (myArr[j] < myArr[j + 1])
                    {
                        double tmp = myArr[j];
                        myArr[j] = myArr[j + 1];
                        myArr[j + 1] = tmp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", myArr[i]);
            }

        }

        public static void XuatMaTran(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j].ToString() + "    ");
                }
                Console.WriteLine();
            }
        }

        public static  void Bai25()
        {
            //int[,] a , b;
            Console.WriteLine("\t---- Nhập ma trận thứ nhất ! ---- \n"); /////////////
            Console.Write("Nhập số dòng : ");
            int m = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (m <= 0)
                {
                    Console.WriteLine("Số côt không âm (m >= 1) !");
                    Console.Write("Nhập số cột : ");
                    m = Convert.ToInt32(Console.ReadLine());
                }
            } while (m <= 0);


            Console.Write("Nhập số cột: ");
            int n = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (n <= 0)
                {
                    Console.WriteLine("Số dòng không âm (m >= 1) !");
                    Console.Write("Nhập số cột : ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
            } while (n <= 0);


            Console.WriteLine("\t ---- Nhập ma trận thứ hai ! ---- \n "); //////////////
            Console.Write("Nhập số cột : ");
            int h = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (h <= 0)
                {
                    Console.WriteLine("Số cột không âm (m >= 1) !");
                    Console.Write("Nhập số cột : ");
                    h  = Convert.ToInt32(Console.ReadLine());
                }
            } while (h <= 0);
           

            int dong = Math.Max(m, n);
            int cot = Math.Max(n, h);
            int[,] a = new int[dong, cot];
            int[,] b = new int[dong, cot];

            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    a[i, j] = 0;
                    b[i, j] = 0;
                }
            }
            
            Console.WriteLine("\n Nhập phần tử ma trận thứ nhất : "); //////////////////
            Console.WriteLine("A[{0}][{1}] ", m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"A[{i + 1}][{j + 1}] = ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Nhập phần tử ma trận thứ hai : "); /////////////////////
            Console.WriteLine("B[{0}][{1}] ", n, h);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    Console.Write($"B[{i + 1}][{j + 1}] = ");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n ------------------ Thông tin ma trận thứ nhất ! -----------------------");
            XuatMaTran(a);
            Console.WriteLine("\n ------------------ Thông tin ma trận thứ hai ! -----------------------");
            XuatMaTran(b);
            Console.WriteLine("\n ------------------ Kết quả cộng hai ma trận ! -----------------------");
            CongHaiMaTran2(a, b, dong, cot);

        }
        // dong m cot n , dong n cot h
        public static void  CongHaiMaTran2(int [,] a , int[,] b , int dong , int cot)
        {
            
            int[,] c = new int[dong, cot];
            for (int i = 0; i < dong; i++)
            {
                for(int j = 0; j < cot; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write
                        (c[i , j].ToString() + "     ");
                }
                Console.WriteLine();
            }
        }
        
        // Hàm cộng hai ma trận
        public static void CongHaiMaTran1(int[,]  a, int [,] b)
        {
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
            {
                Console.WriteLine("Hai ma trận không thể cộng !");
            }
            else
            {
                int[,] c = new int[a.GetLength(0) , a.GetLength(1)];

                // Tiến hành cộng từng phần tử
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        c[i, j] = a[i, j] + b[i, j];
                    }
                }

                Console.WriteLine("\nKết quả cộng hai ma trận !");
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        Console.Write(c[i, j].ToString() + "    ");
                    }
                    Console.WriteLine();
                }
            }
        }

        // Hàm nhân hai ma trận 
        public static void NhanHaiMaTran(int[,] a , int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
            {
                Console.WriteLine("\nKhông thể nhân hai ma trận !");
            }
            else
            {
                int rowsA = a.GetLength(0);
                int colsA = a.GetLength(1);
                int colsB = b.GetLength(1);

                int[,] c = new int[rowsA, colsB];

                // Nhân ma trận
                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < colsB; j++)
                    {
                        int sum = 0;

                        for (int k = 0; k < colsA; k++)
                        {
                            sum += a[i, k] * b[k, j];
                        }

                        c[i, j] = sum;
                    }
                }

                // Xuất ma trận kết quả 
                Console.WriteLine("\nKết quả nhân hai ma trận !");
                for (int i = 0; i < rowsA; i++)
                {
                    for (int j = 0; j < colsB; j++)    
                    {
                        Console.Write(c[i, j] + "    ");
                    }
                    Console.WriteLine();
                }
            }
            //if (a.GetLength(1) != b.GetLength(0))
            //{
            //    Console.WriteLine("\n Không thể nhân hai ma trận !");
            //}
            //else
            //{
            //    int[,] c = new int[a.GetLength(0), b.GetLength(1)];
            //    for (int i = 0; i < a.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < b.GetLength(1); j++)
            //        {
            //            int sum = 0;

            //            for (int k = 0; k < a.GetLength(1); k++)
            //            {
            //                sum += a[i, k] + b[k, j];
            //            }
            //            c[i, j] = sum;
            //        }
            //    }
            //    Console.WriteLine("\nKết quả nhân hai ma trận !");
            //    for (int i = 0; i < c.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < c.GetLength(1); j++)
            //        {
            //            Console.Write(c[i, j].ToString() + "    ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;
            //Bai21();
            //Bai22();
            //Bai23();
            Bai25();
        }

    }
}
