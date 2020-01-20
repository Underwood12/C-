using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File读写
{
    class Program
    {
        static byte[] byteArray;
        static void Main(string[] args)
        {
            //byteArray = File.ReadAllBytes(@"C:\Users\ttwl94804\Desktop\Text2.txt");
            //foreach (var item in byteArray)
            //{
            //    Console.Write(item);
            //}

            //**********************************n 
            byteArray = File.ReadAllBytes("3e3ae4bb2be85ed06fef8e3b9974462.png");
            File.WriteAllBytes("4.png", byteArray);
            //File.WriteAllText("Text1.txt", "Hello World! fucktanweizhao");
            Console.Read();
        }
    }
}
