using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //float f = 1f / 3;
            //double d = 1d / 3;
            //decimal m = 1m / 3;
            ////Float bieu dien duoc toi da 7 so thap phan
            //Console.WriteLine(" f = {0}", f);
            ////Double Bieu dien duoc toi da 15 so thap phan
            //Console.WriteLine(" d = {0}", d);
            ////Decimail Bieu dien duoc toi da 28 so thap phan
            //Console.WriteLine(" m = {0}", m);
            //Khai bao 3 bien
            //float cd, cr, s;
            //Khai bao tung bien
            float cd = 0;
            int cr = 0;
            Console.Write("Nhap chieu dai: ");
            // nhap mot chuoi tu ban phim Console.ReadLine();
            cd  = float.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            cr = int.Parse(Console.ReadLine());
            float s = cd * cr;
            
            //Cach 1 lệnh Console.WriteLine("") là xuất một chuỗi ra màn hình.
            Console.WriteLine("Dien tich cua HCN co cd = {0} va cr = {1} là: {2}",cd,cr,s,cd);
            //Cach 2
           // Console.WriteLine("Dien tich cua HCN co cd = " + cd + " va cr " + cr);
            Console.ReadKey();

        }
    }
}
