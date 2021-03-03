using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Nguyen van toan thang    ";
            //string[] tu = a.Trim().Split(' ');
            // Console.WriteLine(a.Trim().Split(' ')[0]);
            //Tim vi tri khoang trang cuoi cung
            

            int vt = a.Trim().LastIndexOf(' ');
            //Lay chuoi con tu vi tri khoang trang cuoi cung den het chuoi
            Console.WriteLine(a.Substring(vt + 1, a.Length - vt - 1));
            string[] tu = a.Trim().Split(' ');
            Console.WriteLine(tu[tu.Length-1]);
            string soDienThoai = "0665565650";

        }
    }
}
