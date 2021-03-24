using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDongGoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tao mot doi tuong a thuoc kieu Phan So
            //PhanSo a = new PhanSo();
            //PhanSo a = new PhanSo(1, 2);
            //PhanSo b = new PhanSo(3, 4);
            //// a.Nhap();
            //a.Xuat();
            //b.Xuat();
            //PhanSo kq = a.Cong(a, a);
            //kq.Xuat();

            MangPhanSo m = new MangPhanSo();
            m.NhapNgauNghien();
            m.Xuat();
            //m.TinhTong().Xuat();
            Console.WriteLine( "Danh sach phan so duong ");
            //m.TimPhanSoDuong().Xuat();
            m.TimPhanTuXuatHienNhieuNhat().Xuat();
            Console.ReadKey();

        }
    }
}
