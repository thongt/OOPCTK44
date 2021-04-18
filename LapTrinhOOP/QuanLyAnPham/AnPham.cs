using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    interface IAnPham
    {
        string Ten { get; }
        float GiaTien { get; }
        string NhaXuatBan { get; }
        
    }
}
