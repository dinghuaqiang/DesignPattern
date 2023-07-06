using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Build
{
    /// <summary>
    /// Builder，抽象建造者 为创建产品各个部分，统一抽象接口
    /// </summary>
    public abstract class ItemBuilder
    {
        private int _id;
        private string _name;
        public string ItemName;

        public ItemBuilder(int id, string name = "") 
        {
            _id = id;
            ItemName = name;
            ReadCfg();
        }

        private void ReadCfg()
        {
            Console.WriteLine(string.Format("读取ID为:{0}的配置数据...", _id));
        }

        public abstract void BuildQuality();
        public abstract void BuildIcon();
        public abstract void BuildDesc();
        public abstract void BuildSize();
    }
}
