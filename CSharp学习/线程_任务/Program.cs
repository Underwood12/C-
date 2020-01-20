using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 线程_任务//Task继承线程池优点，解决线程池的缺点
{
    class Program
    {
        static int a = 5;
        static void Test()
        {
            Console.WriteLine("开启线程" + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("结束线程" + Thread.CurrentThread.ManagedThreadId);
        }
        static void Test1()//两线程同时运行统一方法，导致不可能发生的事情发生了
        {
            while(true)
            {
                a++;
                if (a == 5)
                {
                    Console.WriteLine("a=5");
                }
                a = 5;
            }
        }

        static void Main(string[] args)
        {
            //Task task = new Task(Test);//这个名字叫任务//任务开启方法一
            //task.Start();

            TaskFactory taskFactory = new TaskFactory();//任务工厂//任务开启方法二
            Task task = taskFactory.StartNew(Test1);
            new Task(Test1).Start();

            Console.WriteLine("Main");
            Console.Read();
        }
    }
}
