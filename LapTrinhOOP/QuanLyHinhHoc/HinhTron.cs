using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class HinhTron:HinhHoc
    {
        public float banKinh;
        public HinhTron()
        {
        }
        public HinhTron(float r)
        {
            banKinh = r;
        }
        public float TinhDT()
        {
            return (float)Math.Round(Math.PI * banKinh * banKinh,0);
        }
        public override string ToString()
        {
            return "Hinh tron ban kinh " + banKinh + " dien tich " + TinhDT();
        }

    }
}
