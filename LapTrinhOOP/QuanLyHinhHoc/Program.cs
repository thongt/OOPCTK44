using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = new object();

            DanhSachHinhHoc ql = new DanhSachHinhHoc();
            ql.Them(new HinhTron(4));
            ql.Them(new HinhVuong(7));
            ql.Them(new HinhVuong(7));
            ql.Them(new HinhVuong(12.407f));
            ql.Them(new HinhTron(4));
            ql.Them(new HinhTron(6));
            ql.Them(new HinhTron(7));
            ql.Them(new HinhTron(4));
            ql.Them(new HinhChuNhat(10, 20));
            ql.Them(new HinhChuNhat(10, 20));
            ql.Them(new HinhChuNhat(10, 20));
            ql.Them(new HinhChuNhat(10, 20));
            ql.Them(new HinhChuNhat(10, 20));
            Console.WriteLine(ql);
            Console.WriteLine("Hinh vuong co dien tich lon nhat");
            Console.WriteLine(ql.TimHinhCoDTLonNhat());
            Console.ReadKey();

        }
    }
}
