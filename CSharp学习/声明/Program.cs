using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//静态声明
using a = System.Console;//别名声明

namespace 声明
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("123123");
            a.WriteLine("321321");
            Read();
        }
    }
}
