using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basic.LearnString
{
    public class ChuanHoaChuoi
    {
        public string strChuanHoa;
        public ChuanHoaChuoi()
        {

            strChuanHoa = "";
        }

        public void Nhap_ChuanHoaChuoi()
        {
            strChuanHoa = Console.ReadLine(); // Nhập chuỗi Họ và tên;
            Console.WriteLine("Chuỗi bạn muốn chuẩn hóa là : " + this.strChuanHoa);
        }
        
        public void Xuat_ChuanHoaChuoi()
        {
            Console.WriteLine("Chuỗi sau khi chuẩn hóa là : " + this.strChuanHoa);
        }  
        public void  ChuanHoa()
        {
            this.strChuanHoa = this.strChuanHoa.Trim();
            this.strChuanHoa = this.strChuanHoa.ToLower();
            //while(this.strChuanHoa.IndexOf("  ") !=  1)
            //{
            //    this.strChuanHoa = this.strChuanHoa.Remove(this.strChuanHoa.IndexOf("  "),1);
            //}
            this.strChuanHoa = string.Join(" ",
                        this.strChuanHoa.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            string[] s = this.strChuanHoa.Split(' '); // Tách các ký tự trong str;
            string alfterFormat = "";
            for(int i = 0; i < s.Length; i++)
            {
                string fist = s[i].Substring(0, 1); // Lấy ký tự đầu tiên của chuỗi đó;
                string another = s[i].Substring(1 , s[i].Length - 1);
                alfterFormat += fist.ToUpper() + another + " ";
            }
            alfterFormat = alfterFormat.Remove(alfterFormat.LastIndexOf(' '), 1);
            this.strChuanHoa = alfterFormat;
        }


        public bool Check_Ten(string str)
        {
            if(str.Length == 0)
            {
                Console.WriteLine("Chuỗi rỗng , vui lòng nhập lại !");
                return false;
            }
            else
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (Char.IsLetter(str[i]) == false && str[i] != ' ')
                    {
                        Console.WriteLine("Chuỗi không hợp lệ , vui lòng nhập lại !");
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
