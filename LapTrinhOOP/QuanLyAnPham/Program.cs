using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachAnPham ds = new DanhSachAnPham();
            ds.NhapTuFile();
            Console.WriteLine(ds);
            ds.SapXepTheoTen();

            //Console.WriteLine(" An pham co gia cao nhat " + ds.TimAnPhamCoGiaCaoNhat());
            Console.WriteLine("Sap xep theo ten \n" + ds);
            ds.SapXepTheoGia();
            Console.WriteLine("Sap xep theo gia\n" + ds);
            Console.ReadKey();
        }
    }
}
