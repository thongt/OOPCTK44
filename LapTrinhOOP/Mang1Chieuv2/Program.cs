using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1Chieuv2
{
    class Program
    {
        static int length = 0; //
        static int[] a = new int[100];
        static void Main(string[] args)
        {
            NhapNgauNghien();
            Xuat();
            //Console.WriteLine("Tong cac phan tu la " + TinhTong());
            //int y = 0;
            //Console.Write("Nhap vao phan tu can xoa");
            //y = int.Parse(Console.ReadLine());
            ////int vt=  TimViTriDauTien(y);
            ////Console.WriteLine("Vi tri cua {0} la {1} ",y,vt);
            //XoaPhanTuDauTien(y);
            int lenkq = 0;
            int [] kq = TimPhanTuXuatHienNhieuNhat(ref lenkq);
            Console.WriteLine("\nPhan tu xuat hien nhieu nhat");
            for (int i = 0; i < lenkq; i++)
            {
                Console.Write("\t " + kq[i]);
            }
        //    Xuat();
            Console.ReadKey();

            //int n = 0; //so phan tu duoc su dung trong mang
        }
        static void XoaPhanTuDauTien(int x)
        {
            XoaPhanTuTaiViTri(TimViTriDauTien(x));
        }
        static int TimViTriDauTien(int x)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i] == x) return i;
            }
            return -1;
        }
        static void XoaPhanTuTaiViTri(int vt)
        {
            for (int i = vt; i < length-1; i++)
            {
                a[i] = a[i + 1];
            }
            length--;
        }
        static int TimViTriCuoiCung(int x)
        {
            for (int i = length-1; i >= 0; i--)
            {
                if (a[i] == x) return i;
            }
            return -1;
        }
        static void NhapNgauNghien()
        {
            Console.Write("Nhap vao so phan tu cua mang ");
            length = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = r.Next(10);
            }
        }
        static void Nhap()
        {
            Console.Write("Nhap vao so phan tu cua mang ");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write(" a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

        }
        static int TinhTongCacSoNguyen()
        {
            int tong = 0;
            for (int i = 0; i < length; i++)
            {
                tong += a[i];
            }
            return tong;
        }
        
        static void Xuat()
        {
            Console.WriteLine("Mang vua nhap la ");
            for (int i = 0; i < length; i++)
            {
                Console.Write("\t " + a[i]);
            }
        }
        static int[] TimPhanTuXuatHienNhieuNhat(ref int lenkq)
        {
            int[] kq = new int[100];
            int max = DemSoLanXuatHienNhieuNhat();
            for (int i = 0; i < length; i++)
            {
               if(DemSoLanXuatHien(a[i])==max && !KiemTraTonTai(kq,lenkq, a[i]))
                    kq[lenkq++] = a[i];

            }
            return kq;
        }
        static bool KiemTraTonTai(int []kq, int lenkq, int x)
        {
            for (int i = 0; i < lenkq; i++)
            {
                if (kq[i] == x) return true;
            }
            return false;
        }
       static int DemSoLanXuatHienNhieuNhat()
        {
            int max = -1;
            for (int i = 0; i < length; i++)
            {
                if (DemSoLanXuatHien(a[i]) > max)
                    max = DemSoLanXuatHien(a[i]);
            }
            return max;
        }

         static int DemSoLanXuatHien(int v)
        {
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] == v)
                    dem++;
            }
            return dem;
        }
    }
}
