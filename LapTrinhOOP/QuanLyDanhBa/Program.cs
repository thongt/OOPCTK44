using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhBa db = new DanhBa();
            db.NhapTuFile();
            Console.WriteLine(db);
            //db.GhiFile();
            //Console.WriteLine(" Danh sach thue bao co nhieu SDT \n"+db.TimThueBaoCoNhieuSDT());
            //db.SapXepTheoChieuTangCuaTen();
            db.SapXepGiamNgaySinh();
            Console.WriteLine(" sau khi sap xep " + db);
            Console.ReadKey();
        }
    }
}
