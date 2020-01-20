using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReader和StreamWriter读写文本文件
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("Test1.txt");
            //while (true)//读取1
            //{
            //    string str = streamReader.ReadLine();//每次循环读取一行
            //    if (str == null) break;
            //    Console.WriteLine(str);//不支持中文
            //}
            //streamReader.Close();

            //***************读取2***************
            //string str= streamReader.ReadToEnd();
            //streamReader.Close();
            //Console.WriteLine(str);
            //streamReader.Close();

            //****************读取3********************
            //while (true)
            //{
            //    int a = streamReader.Read();
            //    if (a == -1) break;
            //    Console.Write((char)a);
            //}
            //streamReader.Close();

            //******************************************
            StreamWriter streamWriter = new StreamWriter("Test2.txt");
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "q") break;
                streamWriter.WriteLine(str);
            }
            streamWriter.Close();
            Console.Read();
        }
    }
}
