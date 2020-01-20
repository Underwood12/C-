  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func委托
{
    class Program
    {
        static int Test()
        {
            return 1;
        }
        static int Test(string str)
        {
            Console.WriteLine(str);
            return 100;
        }
        static void Main(string[] args)
        {
            Func<int> a = Test;//Func委托要带参数要有返回值，参数是什么，返回值就是什么
            Func<string,int> b = Test;//最后一个参数是返回值类型，前面的参数是真的参数
            b("b");
            Console.WriteLine(b("a"));
            Console.WriteLine(a());
            Console.Read();
        }
    }
}
