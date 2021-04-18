using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class TapChi:IAnPham
    {
        float giaTien;
        string ten;
        string nhaXuatBan;
        public string diaChi;
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

        public TapChi()
        {

        }
        public TapChi(string ten, string nhaXuatBan, float giaTien, string diaChi)
        {
            Ten = ten;
            NhaXuatBan = nhaXuatBan;
            GiaTien = giaTien;
            this.diaChi = diaChi;
        }
        public TapChi(string line)
        {
            string[] s = line.Split(',');
            Ten = s[1];
            NhaXuatBan = s[2];
            GiaTien = int.Parse(s[3]);
            diaChi = s[4];
        }
        public override string ToString()
        {
            return string.Format("Ten tap chi : {0} Nha xuat ban: {1} Gia tien: {2} Dia chi: {3}", Ten, NhaXuatBan, GiaTien, diaChi);
        }
    }
}
