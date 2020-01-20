using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 可选参数//就是调用自身方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(digui(10));
            Console.Read();
        }
        static int digui(int n)//递归，就是自己调用自己
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return digui(n - 1);
        }
    }
}
