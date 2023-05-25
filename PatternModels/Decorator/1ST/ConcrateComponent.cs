using System;
namespace DesignPattern.PatternModels.Decorator.ST
{
    /// <summary>
    /// 具体的装饰对象，给Component追加职责的作用
    /// </summary>
    public class ConcrateComponent : Component
    {
        public ConcrateComponent()
        {
        }

        public override void Operation()
        {
            Console.WriteLine("The real operator object.");
        }
    }
}
