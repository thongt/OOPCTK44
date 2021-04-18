using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n=0; //so phan tu duoc su dung trong mang
            Console.Write("Nhap vao so phan tu cua mang ");
            n = int.Parse(Console.ReadLine());
            //Duyet qua cac phan tu cua mang de nhap
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(" a[{0}] = ",i);
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            int tong = 0;
            //nhap ngau nhien
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(100);
            }

            Console.WriteLine("Mang vua nhap la ");
            for (int i = 0; i <n;  i++)
            {
                Console.Write("\t " + a[i]);
            }
           // int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong = tong + a[i];
            }
            Console.WriteLine(" Tong cac phan tu la " + tong);
            Console.ReadKey();
        }
    }
}
