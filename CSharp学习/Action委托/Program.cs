using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action委托
{
    class Program
    {
        static void PrintSomething()
        {
            Console.WriteLine("Hello World");
        }
        static void PrintSomething(int a )
        {
            Console.WriteLine("int="+a);
        }
        static void PrintSomething(string str)
        {
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Action a = PrintSomething;//Action是系统预定义的没有返回值委托
            Action<int> b = PrintSomething;//带有int参数,没有返回值的委托 
            Action<string> c = PrintSomething;//带有string参数,没有返回值的委托 
            a();
            b(1);
            c("sss");
            Console.Read();
        }
    }
}
