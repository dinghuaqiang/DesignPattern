using System;

namespace DesignPattern.PatternModels.Facade
{
    internal class Equip : IConfigBase
    {
        public void Load()
        {
            Console.WriteLine("Equip Load");
        }

        public void Save()
        {
            Console.WriteLine("Equip Save");
        }
    }
}
