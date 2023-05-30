using System;
namespace DesignPattern.PatternModels.Strategy
{
    /// <summary>
    /// 这里其实相当于是出时候的时候传入具体的算法实现类，通过抽象类来调用
    /// </summary>
    public class StrategyContext
    {
        private StrategyBase _strategyBase;

        public StrategyContext(StrategyBase strategyBase)
        {
            _strategyBase = strategyBase;
        }

        public void Impl()
        {
            _strategyBase.AlgorithmImpl();
        }
    }
}
