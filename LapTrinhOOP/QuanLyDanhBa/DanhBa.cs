using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class DanhBa
    {
        ThueBao[] a = new ThueBao[100];
        int length = 0;
        public void Them(ThueBao tb)
        {
            a[length++] = tb;
        }
        public void NhapTuFile()
        {
            string path = "D:\\data1.txt";
            StreamReader sr = new StreamReader(path);
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                //Console.WriteLine(str);
                Them(new ThueBao(str));
            }
        }
        public void GhiFile()
        {
            string path = "D:\\data2.txt";
            StreamWriter sw = new StreamWriter(path);
            sw.Write(this);
            sw.Flush();
            sw.Close();

        }
        public void Xuat()
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < length; i++)
            {
                int k = i + 1;
                s += k.ToString() + ")  " + a[i];
            }
            return s;
        }
        public int DemSoDTTheoThueBao(string cmnd)
        {
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].soCMND == cmnd)
                    dem++;
            }
            return dem;
        }
        public int TimSoLanSoThueBaoXuatHienNhieuNhat()
        {
            int max = -1;
            for (int i = 0; i < length; i++)
            {
                int dem = DemSoDTTheoThueBao(a[i].soCMND);
                if (dem > max)
                    max = dem;
            }
            return max;
        }
        bool CoChua(ThueBao tb)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i].soCMND == tb.soCMND)
                    return true;
            }
            return false;
        }
        
        public DanhBa TimThueBaoCoNhieuSDT()
        {
            DanhBa kq = new DanhBa();
            int max = TimSoLanSoThueBaoXuatHienNhieuNhat();
            for (int i = 0; i < length; i++)
            {
                if (DemSoDTTheoThueBao(a[i].soCMND) == max && !kq.CoChua(a[i]))
                    kq.Them(a[i]);
            }
            return kq;
        }
        //public void SapXepTheoChieuTangCuaTen()
        //{
        //    for (int i = 0; i < length-1; i++)
        //    {
        //        for (int j = i+1; j < length; j++)
        //        {
        //            if(a[i].hoTen.CompareTo(a[j].hoTen) ==1)
        //            {
        //                ThueBao tam = a[i];
        //                a[i] = a[j];
        //                a[j] = tam;
        //            }
        //        }
        //    }
        //}
        //public void SapXepGiamNgaySinh()
        //{
        //    for (int i = 0; i < length - 1; i++)
        //    {
        //        for (int j = i + 1; j < length; j++)
        //        {
        //            if (a[i].ngaySinh.CompareTo(a[j].ngaySinh) == -1)
        //            {
        //                ThueBao tam = a[i];
        //                a[i] = a[j];
        //                a[j] = tam;
        //            }
        //        }
        //    }
        //}
        public void SapXepTheoChieuTangCuaTen()
        {
            SapXep(KieuSapXep.TangTheoHoTen);
        }
        public void SapXepGiamNgaySinh()
        {
            SapXep(KieuSapXep.GiamTheoNgaySinh);
        }
        public enum KieuSapXep
        {
            TangTheoHoTen,
            GiamTheoHoTen,
            TangTheoNgaySinh,
            GiamTheoNgaySinh
        }
        public void SapXep(KieuSapXep k )
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (KiemTraDieuKien(a[i], a[j], k)==1)
                    {
                        ThueBao tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
                }
            }
        }
        
         private int KiemTraDieuKien(ThueBao thueBao1, ThueBao thueBao2, KieuSapXep k)
        {
            if (k == KieuSapXep.TangTheoHoTen)
                return thueBao1.hoTen.CompareTo(thueBao2.hoTen);
            if (k == KieuSapXep.GiamTheoHoTen)
                return - thueBao1.hoTen.CompareTo(thueBao2.hoTen);
            if (k == KieuSapXep.TangTheoNgaySinh)
                return thueBao1.ngaySinh.CompareTo(thueBao2.ngaySinh);
            if (k == KieuSapXep.GiamTheoNgaySinh)
                return -thueBao1.ngaySinh.CompareTo(thueBao2.ngaySinh);
            return -1;
        }
        public int DemThueBaoTheoThang(int thang)
        {
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if(a[i].Thang == thang)
                {
                    dem++;
                }

            }
            return dem;
        }
       public int TimSoLuongThuBaoCaoNhat()
        {
            int max = -1;
            for (int i = 0; i < length; i++)
            {
                if(max < DemThueBaoTheoThang(a[i].Thang))
                {
                    max = DemThueBaoTheoThang(a[i].Thang);
                }
            }
            return max;
        }
        public int[] TimThangCoThueBaoCaoNhat(ref int len)
        {
            int[] kq = new int[100];
            int max = TimSoLuongThuBaoCaoNhat();
            for (int i = 0; i < length; i++)
            {
                if(DemThueBaoTheoThang(a[i].Thang) == max)
                {
                    kq[len++] = a[i].Thang;
                }
            }
            return kq;
        }
        public List<int> TimThangCoThueBaoCaoNhat()
        {
            List<int> kq = new List<int>();
            int max = TimSoLuongThuBaoCaoNhat();
            for (int i = 0; i < length; i++)
            {
                if (DemThueBaoTheoThang(a[i].Thang) == max && !kq.Contains(a[i].Thang))
                {
                    kq.Add(a[i].Thang);
                }
            }
            return kq;
        }
    }
}
