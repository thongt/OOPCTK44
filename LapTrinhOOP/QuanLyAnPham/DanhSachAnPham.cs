using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class DanhSachAnPham:List<IAnPham>, IComparer<IAnPham>
    {
        public List<IAnPham> collection = new List<IAnPham>();
        public int Compare(IAnPham x, IAnPham y)
        {
            if (kieu == KieuSapXep.TangTheoTen)
                return x.Ten.CompareTo(y.Ten);
            return x.GiaTien.CompareTo(y.GiaTien);
        }
        public void Them(IAnPham ap)
        {
            collection.Add(ap);
        }
        public void NhapTuFile()
        {
            string path = @"data.csv";
            StreamReader sr = new StreamReader(path);
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                string []s = str.Split(',');
                if (s[0] == "Sach")
                    Them(new Sach(str));
                if (s[0] == "Bao")
                    Them(new Bao(str));
                if (s[0] == "Tap chi")
                    Them(new TapChi(str));
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in collection)
            {
                sb.Append(item + "\n");
            }
            return sb.ToString();
        }
        public DanhSachAnPham TimAnPhamCoGiaCaoNhat()
        {
            float max = collection.Max(x => x.GiaTien);
            DanhSachAnPham kq = new DanhSachAnPham();
            kq.collection = collection.FindAll(x=>x.GiaTien == max);
            return kq;
        }
        enum KieuSapXep
        {
            TangTheoTen,
            TangTheoGia
        }
        KieuSapXep kieu = KieuSapXep.TangTheoTen;
        public void SapXepTheoTen()
        {
            kieu = KieuSapXep.TangTheoTen;
            collection.Sort(this);
        }
        public void SapXepTheoGia()
        {
            kieu = KieuSapXep.TangTheoGia;
            collection.Sort(this);
        }

        DanhSachAnPham TimAnPhamTheoGiaTien(int x)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            kq.collection = collection.FindAll(a => a.GiaTien == x);
            return kq;
        }
        DanhSachAnPham Txxx()
        {
            return (List<IAnPham>)collection.FindAll(a => a.GiaTien == 1);
        }
    }
}
