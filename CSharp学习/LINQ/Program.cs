using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var masterlist = new List<MartialArtsMaster>()
            {
                new MartialArtsMaster(){ID=1,name="黄蓉",Age=18,MenPai="丐帮",KongFu="打狗棍法",Level=9},
                new MartialArtsMaster(){ID=2,name="洪七公",Age=70,MenPai="丐帮",KongFu="打狗棍法",Level=10},
                new MartialArtsMaster(){ID=3,name="郭靖",Age=22,MenPai="丐帮",KongFu="江龙十八掌",Level=10},
                new MartialArtsMaster(){ID=4,name="任我行",Age=50,MenPai="明教",KongFu="葵花宝典",Level=1},
                new MartialArtsMaster(){ID=5,name="东方不败",Age=35,MenPai="明教",KongFu="葵花宝典",Level=10}
            }; 
            var kongfu = new List<KongFu>()
            {
                new KongFu(){iD=1,name="打狗棍法",power=90},
                new KongFu(){iD=2,name="江龙十八掌",power=95},
                new KongFu(){iD=3,name="葵花宝典",power=100},
                new KongFu(){iD=4,name="独孤九剑",power=100}
            };

            //****************使用foreach查询************************
            //List<MartialArtsMaster> res=new List<MartialArtsMaster>();
            //foreach (var item in masterlist)
	        //{
             //   if(item.Level>=8)
             //   {
             //       res.Add(item);
            //        Console.WriteLine(item.DeBug1());
            //    }
	       // }


            //*********************LinQ表达式
            //var res = from m in masterlist
            //          where m.Level >= 8
            //          select m.DeBug1();

            //********************Linq扩展方法写法
            //var res= masterlist.Where(a=>a.Level>8);
            //var res=masterlist.Where(Test());

            Console.Read();
        }

       static bool Test(MartialArtsMaster list)
        {
            if (list.Level >= 8) return true;
            else return false;
        }
    }
}
