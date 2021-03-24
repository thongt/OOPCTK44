using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDongGoi
{
    class PhanSo
    {
       public int tu;
        public int mau;
        public PhanSo()
        {
          //  mau = 1;
        }
        public PhanSo(int t, int m)
        {
            tu = t;
            mau = m;
        }
        public void NhapNgauNhien()
        {
            Random r = new Random();
            tu = r.Next(-10, 10);
            mau = r.Next(1, 10);
        }
        public void Nhap()

        {
            Console.Write("Nhap tu ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau ");
            mau = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.Write("\t {0}/{1}",tu,mau);
        }
        public PhanSo Cong(PhanSo a, PhanSo b)
        {
            PhanSo kq = new PhanSo(0, 1);
            kq.tu = a.tu * b.mau + a.mau * b.tu;
            kq.mau = a.mau * b.mau;
            return kq;
        }

    }
}
