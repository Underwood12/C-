using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    delegate float MyDelegate(float a, float b);
    class Program
    {
       static float Mul(float a,float b)
        {
            Console.WriteLine(a * b);
            return a * b;
        }
       static float Dev(float a,float b)
        {
            Console.WriteLine(a / b);
            return a / b;
        }
        static void Main(string[] args)
        {
            MyDelegate de;
            //de = Mul;
            de = Dev;
            de += Mul;//多播委托，一个委托放进多个方法
            de(4, 2);
            Console.Read();
        }
    }
}
