using System;
namespace DesignPattern.PatternModels.SimpleFactory
{
    public class OperationMul : OperationBase
    {
        public override double GetResult()
        {
            return NumX * NumY;
        }
    }
}
