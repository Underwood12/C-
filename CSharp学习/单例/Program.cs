using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    #region 单例模式一,sealed不能做其他类的基类  
    /// <summary>
    /// 强烈推荐单例一。缺点：由于启动就会实例化，会过早地占用内存
    /// </summary>
    public sealed class Singleton
    {
        Singleton() { }
        static Singleton _Instance=new Singleton();
        public static Singleton Instance
        {
            get
            {
                return _Instance;
            }
        }
    }
    #endregion

    #region 单例模式二
    /// <summary>
    /// 单例模式二，优点：需要用到的时候会被调用，而不会过早调用
    /// </summary>
    public sealed class Singleton1
    {
        public Singleton1()
        {
        }
        public static Singleton1 Instance
        {
            get => Nested._Instance;
        }
    }
    class Nested
    {
        public Nested()
        {
        }
        internal static readonly Singleton1 _Instance = new Singleton1();
    }
    #endregion
}
