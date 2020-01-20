using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class DerivedClass:BaseClass
    {
        float y;
        public DerivedClass()
        {
            Console.WriteLine("这是DeriveClass构造函数");
        }
        public DerivedClass(int x,float y):base(x)//把子类的X传给父类
        {
            this.y = y;
            Console.WriteLine(x + "+++" + y);
        }
    }
}
