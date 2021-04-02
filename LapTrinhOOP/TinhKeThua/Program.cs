using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhKeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.XuatA();
            A a = new A();
            a.XuatA();
            a = b;
            ((B)a).XuatB();//unbox
            a.XuatA();
            b = (B)a;
            b.XuatB();
            Console.ReadKey();
        }
    }
}
