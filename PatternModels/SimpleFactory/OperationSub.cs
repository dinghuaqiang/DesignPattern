using System;
namespace DesignPattern.PatternModels.SimpleFactory
{
    public class OperationSub : OperationBase
    {
        public override double GetResult()
        {
            return NumX - NumY;
        }
    }
}
