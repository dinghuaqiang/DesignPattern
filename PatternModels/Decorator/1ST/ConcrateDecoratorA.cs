using System;
namespace DesignPattern.PatternModels.Decorator.ST
{
    public class ConcrateDecoratorA : Decorator
    {
        private string _name = "ConcrateDecoratorA";
        private string _status = "Idle";

        public override void Operation()
        {
            //执行原装饰类的操作再执行这个类的操作
            base.Operation();
            Console.WriteLine("ConcrateDecoratorA operation function excuted!");
        }
    }
}
