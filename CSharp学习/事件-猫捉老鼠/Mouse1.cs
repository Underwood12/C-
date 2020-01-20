using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件_猫捉老鼠
{
    class Mouse1
    {
        string name,color;
        public Mouse1(string name, string color)
        {
            this.color = color;
            this.name = name;
        }
        public void RunAway()
        {
            Console.WriteLine(string.Format("{0}的老鼠{1}说:“老猫来了”",color,name));
        }
    }
}
