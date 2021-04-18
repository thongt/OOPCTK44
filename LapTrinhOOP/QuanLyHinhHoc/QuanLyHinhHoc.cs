using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class DanhSachHinhHoc
    {
        List<IHinhHoc> collection = new List<IHinhHoc>();
        public void Them(IHinhHoc hh)
        {
            collection.Add(hh);
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in collection)
            {
                s += "\n" + item;
            }
            return s;
        }
        float TimDienTichHinhVuongLonNhat()
        {
            float max = -1;
            foreach (var item in collection)
            {
                
                if(item is HinhVuong )
                {
                    float dt = ((HinhVuong)item).TinhDT();
                    if(dt>max)
                       max = dt;
                }
            }
            return max;
        }
        public DanhSachHinhHoc TimHinhVuongCoDTLonNhat()
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = TimDienTichHinhVuongLonNhat();
            foreach (var item in collection)
            {
                if (item is HinhVuong && ((HinhVuong)item).TinhDT() == max)
                    kq.Them(item);
            }
            return kq;
        }

        float TimDienTichLonNhat()
        {
            //float max = -1;
            //foreach (var item in collection)
            //{
            //    //float dt = 0;
            //    //if (item is HinhVuong)
            //    //     dt = ((HinhVuong)item).TinhDT();
            //    //if (item is HinhTron)
            //    //     dt = ((HinhTron)item).TinhDT();
            //    //if (dt > max)
            //    //    max = dt;
            //    if (item.TinhDT() > max)
            //        max = item.TinhDT();
            //}
            return collection.Max(x => x.TinhDT());
          //  return max;
        }
        public DanhSachHinhHoc TimHinhCoDTLonNhat()
        {
            //DanhSachHinhHoc kq = new DanhSachHinhHoc();
            //float max = TimDienTichLonNhat();
            //foreach (var item in collection)
            //{
            //    //if (item is HinhVuong && ((HinhVuong)item).TinhDT() == max)
            //    //    kq.Them(item);
            //    //if (item is HinhTron && ((HinhTron)item).TinhDT() == max)
            //    //    kq.Them(item);
            //    if (item.TinhDT() == max)
            //        kq.Them(item);
            //}
            //return kq;
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = TimDienTichLonNhat();
            kq.collection = collection.FindAll(x => x.TinhDT() == max);
            return kq;
        }
    }
}
