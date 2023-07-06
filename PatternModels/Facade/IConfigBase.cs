using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Facade
{
    internal interface IConfigBase
    {
        void Load();
        void Save();
    }
}
