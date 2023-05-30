using System;
namespace DesignPattern.PatternModels.SimpleFactory
{
    public class OperationAdd : OperationBase
    {
        public override double GetResult()
        {
            return NumX + NumY;
        }
    }
}
