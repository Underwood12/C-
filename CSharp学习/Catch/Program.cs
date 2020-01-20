using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;int age;
            WriteLine("输入你的名字");
            name=ReadLine();
            WriteLine("输入你的年龄");
            try
            {
                age = Read();
            }
            catch(FormatException)
            {
                WriteLine($"输入年龄错误,{age}不存在");
            }
            finally
            {

            }


        }
    }
}
