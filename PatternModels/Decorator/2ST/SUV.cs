using System;
namespace DesignPattern.PatternModels.Decorator.ST
{
    public class SUV : CarDecorate
    {
        private void MorePowerful()
        {
            Console.WriteLine("Make the engine more powerful.");
        }

        /// <summary>
        /// 增加OTA支持
        /// </summary>
        private void AddOtaSupport()
        {
            Console.WriteLine("Install OTA Support.");
        }

        /// <summary>
        /// 让底盘更高
        /// </summary>
        private void MoreHigher()
        {
            Console.WriteLine("Make the suv chassis more higher.");
        }

        /// <summary>
        /// 让悬架更软
        /// </summary>
        private void MoreSoft()
        {
            Console.WriteLine("Make the suspension more soft.");
        }

        public override void Create()
        {
            base.Create();
            AddOtaSupport();
            MorePowerful();
            MoreHigher();
            MoreSoft();
            Console.WriteLine("Created a suv car.");
        }
    }
}
