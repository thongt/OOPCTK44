using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZBai12_QuanLyMayTinh
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachMayTinh ds = new DanhSachMayTinh();
            ds.NhapTuFile();
            Console.WriteLine("Danh sach may tinh la ");
            Console.WriteLine(ds);
            //Console.WriteLine("\n---------------------\nDanh sach may tinh co ga cao nhat la ");
            //Console.WriteLine(ds.TimMayTinhCoGiaCaoNhat());
            //Console.WriteLine(" Dem hang Intel " + ds.DemThietBiTheoHang("Intel"));
            Console.WriteLine(" Danh sach cac hang khong trung nhau la ");
            foreach (string s in ds.TimDanhSachHang())
                Console.WriteLine(s);

            Console.WriteLine(" Hang xuat hien nhieu nhat la ");
            foreach (string s in ds.TimHangXuatHienNhieuNhat())
                Console.WriteLine(s + " so lan " + ds.DemThietBiTheoHang(s));
            Console.ReadKey();
        }
    }
}
