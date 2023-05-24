using System;
namespace DesignPattern.PatternModels.Strategy
{
    public abstract class StrategyBase
    {
        /// <summary>
        /// 抽象出具体的算法实现让子类去继承
        /// </summary>
        public abstract void AlgorithmImpl();
    }
}
