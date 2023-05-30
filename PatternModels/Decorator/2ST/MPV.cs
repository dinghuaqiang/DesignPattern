using System;
namespace DesignPattern.PatternModels.Decorator.ST
{
    public class MPV : CarDecorate
    {
        private void LargeSpace()
        {
            Console.WriteLine("Make mpv car hold large space.");
        }

        public override void Create()
        {
            base.Create();
            LargeSpace();
            Console.WriteLine("Created a mpv car.");
        }
    }
}
