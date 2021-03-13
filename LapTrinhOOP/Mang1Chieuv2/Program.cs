using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1Chieuv2
{
    class Program
    {
        static int n = 0; //
        static int[] a = new int[100];
        static void Main(string[] args)
        {
            NhapNgauNghien();
            Xuat();
            //Console.WriteLine("Tong cac phan tu la " + TinhTong());
            int y = 0;
            Console.Write("Nhap vao phan tu can xoa");
            y = int.Parse(Console.ReadLine());
            //int vt=  TimViTriDauTien(y);
            //Console.WriteLine("Vi tri cua {0} la {1} ",y,vt);
            XoaPhanTuDauTien(y);
            Xuat();
            Console.ReadKey();

            //int n = 0; //so phan tu duoc su dung trong mang
        }
        static void XoaPhanTuDauTien(int x)
        {
            XoaPhanTuTaiViTri(TimViTriDauTien(x));
        }
        static int TimViTriDauTien(int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x) return i;
            }
            return -1;
        }
        static void XoaPhanTuTaiViTri(int vt)
        {
            for (int i = vt; i < n-1; i++)
            {
                a[i] = a[i + 1];
            }
            n--;
        }
        static int TimViTriCuoiCung(int x)
        {
            for (int i = n-1; i >= 0; i--)
            {
                if (a[i] == x) return i;
            }
            return -1;
        }
        static void NhapNgauNghien()
        {
            Console.Write("Nhap vao so phan tu cua mang ");
            n = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(100);
            }
        }
        static void Nhap()
        {
            Console.Write("Nhap vao so phan tu cua mang ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(" a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

        }
        static int TinhTongCacSoNguyen()
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        
        static void Xuat()
        {
            Console.WriteLine("Mang vua nhap la ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\t " + a[i]);
            }
        }
    }
}
