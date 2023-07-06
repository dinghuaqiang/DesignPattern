using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Build
{
    public class WeaponItem : ItemBuilder
    {
        public WeaponItem(int id, string name = "") : base(id, name)
        {
        }

        public override void BuildDesc()
        {
            Console.WriteLine("WeaponItem BuildDesc...");
        }

        public override void BuildIcon()
        {
            Console.WriteLine("WeaponItem BuildIcon...");
        }

        public override void BuildQuality()
        {
            Console.WriteLine("WeaponItem BuildQuality...");
        }

        public override void BuildSize()
        {
            Console.WriteLine("WeaponItem BuildSize...");
        }
    }
}
