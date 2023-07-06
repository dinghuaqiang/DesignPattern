using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Facade
{
    internal class Roles : IConfigBase
    {
        public void Load()
        {
            Console.WriteLine("Roles Load");
        }

        public void Save()
        {
            Console.WriteLine("Roles Save");
        }
    }
}
