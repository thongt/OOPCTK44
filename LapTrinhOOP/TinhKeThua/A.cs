using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhKeThua
{
    public class A
    {
        protected int intA=10;
        public A()
        {
        }
        public A(int a)
        {
            intA = a;
        }
        public void XuatA()
        {
            Console.WriteLine(" Gia tri cua intA la " + intA);
        }
    }
    public class B : A
    {
        int  intB;
        public B()
        {

        }
        //public B(int a, int b)
        //{
        //    intA = a;
        //    intB = b;
        //}
        public B(int a, int b):base(a)
        {
            intB = b;
        }
        public void XuatB()
        {
            Console.WriteLine("IntA = {0}, intB={1}", intA, intB);
        }
    }
}
