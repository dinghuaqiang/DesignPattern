using DesignPattern.PatternModels.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Facade
{
    /// <summary>
    /// 外观模式
    /// 其实就是提供一个封装类，在里面处理操作，提供尽量少的接口给外部去使用
    /// 类似于基金和股票的区别，基金经理操作股票，散户投资，不用管基金经理去买卖哪些股票
    /// </summary>
    public class ConfigsFacadeMain
    {
        private static void Main(string[] args)
        {
            ConfigManager configManager = new ConfigManager();
            configManager.Load();
            configManager.Save();
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
