using System;
namespace DesignPattern.PatternModels.SimpleFactory
{
    public class OperationBase
    {
        public double NumX { get; set; }
        public double NumY { get; set; }

        public virtual double GetResult()
        {
            return 0;
        }
    }
}
