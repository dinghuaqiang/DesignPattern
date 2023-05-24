using System;
namespace DesignPattern.PatternModels.Strategy
{
    public class StrategyX : StrategyBase
    {

        public override void AlgorithmImpl()
        {
            Console.WriteLine("StrategyX AlgorithmImpl");
        }
    }
}
