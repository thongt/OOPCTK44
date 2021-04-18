using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class Bao : IAnPham
    {
        float giaTien;
        string ten;
        string nhaXuatBan;
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

        public Bao()
        {

        }
        public Bao(string ten, string nhaXuatBan, float giaTien)
        {
            Ten = ten;
            NhaXuatBan = nhaXuatBan;
            GiaTien = giaTien;
        }
        public Bao(string line)
        {
            string[] s = line.Split(',');
            Ten = s[1];
            NhaXuatBan = s[2];
            
            GiaTien = float.Parse(s[3]);
        }
        public override string ToString()
        {
            return string.Format("Ten bao : {0} Nha xuat ban: {1} Gia tien: {2}", Ten, NhaXuatBan, GiaTien);
        }
    }
}
