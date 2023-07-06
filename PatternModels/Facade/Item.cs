using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Facade
{
    internal class Item : IConfigBase
    {
        public void Load()
        {
            Console.WriteLine("Item Load");
        }

        public void Save()
        {
            Console.WriteLine("Item Save");
        }
    }
}
