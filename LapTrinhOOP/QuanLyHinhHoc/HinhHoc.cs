using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    //class HinhHoc
    //{
    //    public virtual float TinhDT()
    //    {
    //        return 0;
    //    }
    //}

    // abstract class HinhHoc
    //{
    //    public abstract float TinhDT();
    //    public float TinhCV()
    //    {
    //        return 0;
    //    }
    //}
    interface IHinhHoc
    {
        float TinhDT();
    }
}
