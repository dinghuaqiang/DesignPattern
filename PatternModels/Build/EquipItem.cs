using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Build
{
    public class EquipItem : ItemBuilder
    {
        public EquipItem(int id, string name = "") : base(id, name)
        {

        }

        public override void BuildDesc()
        {
            Console.WriteLine("EquipItem BuildDesc... Build item name is " + ItemName);
        }

        public override void BuildIcon()
        {
            Console.WriteLine("EquipItem BuildIcon...");
        }

        public override void BuildQuality()
        {
            Console.WriteLine("EquipItem BuildQuality...");
        }

        public override void BuildSize()
        {
            Console.WriteLine("EquipItem BuildSize...");
        }
    }
}
