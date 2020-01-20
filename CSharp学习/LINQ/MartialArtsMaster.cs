using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    /// <summary>
    /// 武林高手
    /// </summary>
    class MartialArtsMaster
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int Age { get; set; }
        public string MenPai { get; set; }
        public string KongFu { get; set; }
        public int Level { get; set; }
        public string DeBug1()
        {
            return string.Format("ID={0},name={1},age={2},menpai={3},kongfu={4},level={5}", ID, name, Age, MenPai, KongFu, Level);
        }
    }
}
