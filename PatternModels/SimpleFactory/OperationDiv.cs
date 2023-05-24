using System;
namespace DesignPattern.PatternModels.SimpleFactory
{
    public class OperationDiv : OperationBase
    {
        public override double GetResult()
        {
            if (NumY == 0)
            {
                Console.WriteLine("除数不能为0!");
                return 0;
            }
            return NumX / NumY;
        }
    }
}
