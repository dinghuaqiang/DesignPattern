using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Facade
{
    public class ConfigManager
    {
        Equip equip = null;
        Item item = null;
        Roles roles = null;
        public ConfigManager()
        {
            equip = new Equip();
            item = new Item();
            roles = new Roles();
        }

        public void Load() 
        {
            equip.Load();
            item.Load();
            roles.Load();
        }

        public void Save() 
        {
            equip.Save();
            item.Save();
            roles.Save();
        }

    }
}
