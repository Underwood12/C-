using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSteam读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream readStream = new FileStream("Test1.txt", FileMode.Open);
            FileStream writeStream = new FileStream("Test2.txt", FileMode.Create);
            byte[] byteArray = new byte[1024];

            int length = readStream.Read(byteArray, 0, byteArray.Length);
            writeStream.Write(byteArray,0,length);
            readStream.Close();
            writeStream.Close();


            Console.Read();
        }
    }
}
