using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class BaseClass
    {
        public BaseClass()
        {
            System.Console.WriteLine("这是BaseClass构造函数");
        }
        public BaseClass(int x)
        {
            Console.WriteLine(x);
        }
    }
}
