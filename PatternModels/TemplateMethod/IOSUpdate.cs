using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.TemplateMethod
{
    internal class IOSUpdate : UpdateBase
    {
        public override void Extract()
        {
            Console.WriteLine("IOSUpdate 解压缩资源...");
        }
    }
}
