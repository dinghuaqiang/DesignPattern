using System;
namespace DesignPattern.PatternModels.Strategy
{
    /// <summary>
    /// 策略模式的测试入口
    /// 它定义了算法家族，分别封装起来，让它们之间可以互相替换，此模式让算法的变化，不会影响到使用算法的客户。
    /// 主要是处理那种需要在不同时间应用不同的规则的业务就可以考虑使用策略模式
    ///
    /// 用法其实就是抽象出子类的算法，封装成抽象函数，通过Context初始化的时候传入具体的子类实现进行抽象调用
    /// </summary>
    public class StrategyMain
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Strategy partten learning test.");

            StrategyContext context = null;
            context = new StrategyContext(new StrategyX());
            context.Impl();

            context = new StrategyContext(new StrategyY());
            context.Impl();

            context = new StrategyContext(new StrategyZ());
            context.Impl();

            Console.ReadKey();
        }
    }
}
