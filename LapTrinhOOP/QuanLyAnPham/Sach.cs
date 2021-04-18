using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class Sach : IAnPham
    {
        float giaTien;
        string ten;
        string nhaXuatBan;
        public int SoTrang;
        public float GiaTien
        {
            get
            {
                return giaTien;
            }

            set
            {
                giaTien = value;
            }
        }

        public string NhaXuatBan
        {
            get
            {
                return nhaXuatBan;
            }

            set
            {
                nhaXuatBan = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public Sach()
        {

        }
        public Sach(string ten, string nhaXuatBan, float giaTien, int soTrang)
        {
            Ten = ten;
            NhaXuatBan = nhaXuatBan;
            GiaTien = giaTien;
            SoTrang = soTrang;
        }
        public Sach(string line)
        {
            string[] s = line.Split(',');
            Ten = s[1];
            NhaXuatBan = s[2];
            SoTrang = int.Parse(s[3]);
            GiaTien = float.Parse(s[4]);
        }
        public override string ToString()
        {
            return string.Format("Ten sach : {0} Nha xuat ban: {1} Gia tien: {2} So trang: {3}", Ten,NhaXuatBan,GiaTien,SoTrang);
        }
    }
}
