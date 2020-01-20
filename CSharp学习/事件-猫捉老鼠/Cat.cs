using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件_猫捉老鼠
{
    class Cat
    {
        public Action catCome;
        string name, color;
        public Cat(string name,string color)
        {
            this.color = color;
            this.name = name;
        }
        public void CatCome()
        {
            Console.WriteLine(string.Format("{0}的{1}猫来了!", color, name));
            catCome();
        }
    }
}
