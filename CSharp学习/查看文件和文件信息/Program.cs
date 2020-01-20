using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 查看文件和文件信息
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfo fileInfo = new FileInfo("Text1.txt");//相对路径
            FileInfo fileInfo = new FileInfo(@"C: \Users\ttwl94804\Desktop/Text2.txt");//绝对路径
            Console.WriteLine(fileInfo.Exists);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.Directory);//获取上一级路径
            Console.WriteLine(fileInfo.Length);
            //fileInfo.CopyTo(@"C: \Users\ttwl94804\Desktop/Text3.txt");//复制
            Console.WriteLine(fileInfo.IsReadOnly);
            Console.WriteLine(fileInfo.Open(FileMode.Open));
            //fileInfo.Delete();
            Console.Read();
        }
    }
}
