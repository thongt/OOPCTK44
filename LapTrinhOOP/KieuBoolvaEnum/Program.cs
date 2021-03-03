using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KieuBoolvaEnum
{
    class Program
    {
        enum Mua
        {
            Xuan,
            Ha,
            Thu,
            Dong
        }
        static void Main(string[] args)
        {
            //bool b = true;
            //bool a = false;
            //bool x = (a != b);
            int dl = 0;

            Mua dalat = Mua.Ha;
            Console.WriteLine((int)dalat);
            Console.ReadKey();
        }
    }
}
