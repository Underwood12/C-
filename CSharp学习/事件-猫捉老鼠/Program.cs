using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件_猫捉老鼠
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("汤姆", "蓝色");
            Mouse1 mouse1 = new Mouse1("米奇", "黑色");
            Mouse2 mouse2 = new Mouse2("杰克", "棕色");
            cat1.catCome += mouse1.RunAway;
            cat1.catCome += mouse2.RunAway;
            cat1.CatCome();
            Console.Read();
        }
    }
}
