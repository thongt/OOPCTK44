using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDongGoi
{
    class MangPhanSo
    {
        PhanSo[] a = new PhanSo[100];
        int length = 0;
        public void Them(PhanSo x)
        {
            a[length++] = x;
        }
        public void NhapNgauNghien()
        {
            Console.Write("Nhap vao so phan tu cua mang ");
            length = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = new PhanSo(r.Next(-10,10), r.Next(1,10));
               // a[i].NhapNgauNhien();
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < length; i++)
            {
                a[i].Xuat();
            }
        }
        public PhanSo TinhTong()
        {
            PhanSo tong =  new PhanSo(0,1);
            for (int i = 0; i < length; i++)
            {
                tong = tong.Cong(tong, a[i]);
            }
            return tong;
        }
        public MangPhanSo TimPhanSoDuong()
        {
            MangPhanSo kq = new MangPhanSo();
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu / a[i].mau > 0)
                    kq.Them(a[i]);
            }
            return kq;
        }
        public MangPhanSo TimPhanTuXuatHienNhieuNhat()
        {
            MangPhanSo kq = new MangPhanSo();
            int max = DemSoLanXuatHienNhieuNhat();
            for (int i = 0; i < length; i++)
            {
                if (DemSoLanXuatHien(a[i]) == max && !KiemTraTonTai(a[i]))
                    kq.Them(a[i]);
            }
            return kq;
        }
        public bool KiemTraTonTai(PhanSo x)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu == x.tu) return true;
            }
            return false;
        }
        public int DemSoLanXuatHienNhieuNhat()
        {
            int max = -1;
            for (int i = 0; i < length; i++)
            {
                if (DemSoLanXuatHien(a[i]) > max)
                    max = DemSoLanXuatHien(a[i]);
            }
            return max;
        }

         int DemSoLanXuatHien(PhanSo v)
        {
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu == v.tu)
                    dem++;
            }
            return dem;
        }
    }
}
