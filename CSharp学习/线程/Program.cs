using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程//创建花费时间，占用内存与CPU资源
{
    class Program
    {
        static void DownLoad(object fileName)//带参数的线程
        {
            Console.WriteLine("开始下载"+Thread.CurrentThread.ManagedThreadId+fileName);
            Thread.Sleep(2000);
            Console.WriteLine("下载完成");
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(DownLoad);//前台线程
            thread.IsBackground = true;//后台线程
            thread.Start("name");
            Console.WriteLine("Main");
            Console.Read();
        }
    }
}
