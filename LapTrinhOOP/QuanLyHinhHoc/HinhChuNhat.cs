using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class HinhChuNhat:IHinhHoc
    {
        public float cd;
        public float cr;
        public HinhChuNhat()
        {
        }
        public HinhChuNhat(float d, float r)
        {
            cd = d;
            cr = r;
        }
        public float TinhDT()
        {
            return cr * cd;
        }
        public override string ToString()
        {
            return string.Format("Hinh chu nhat cd={0}, cr= {1}, co dien tich = {2}", cd, cr, TinhDT());
        }
    }
}
