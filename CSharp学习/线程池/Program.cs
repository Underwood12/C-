using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 线程池//免去创建Thread时间，直接将方法委托给线程池去安排内部的线程调用。但是用户不能直接关闭，得到结果也很直接
{
    class Program
    {
       static void Test(Object a)
        {
            Console.WriteLine("开启线程" + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("结束线程" + Thread.CurrentThread.ManagedThreadId);
        }
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Test);
            ThreadPool.QueueUserWorkItem(Test);
            ThreadPool.QueueUserWorkItem(Test);
            ThreadPool.QueueUserWorkItem(Test);
            ThreadPool.QueueUserWorkItem(Test);
            ThreadPool.QueueUserWorkItem(Test);

            Console.Read();
        }
    }
}
