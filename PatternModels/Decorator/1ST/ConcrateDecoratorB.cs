using System;
namespace DesignPattern.PatternModels.Decorator.ST
{
    public class ConcrateDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            SomeBehivor();
        }

        private void SomeBehivor()
        {
            Console.WriteLine("Excute some other behivor in ConcrateDecoratorB.");
        }
    }
}
