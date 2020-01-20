using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derivedClass = new DerivedClass();//调用子类构造函数会先调用父类构造函数
            DerivedClass derivedClass1 = new DerivedClass(1,2.1f);
            BaseClass baseClass = new BaseClass(2);
            Console.WriteLine(derivedClass);
            Console.WriteLine(baseClass);
            
            Console.Read();
        }
    }
}
