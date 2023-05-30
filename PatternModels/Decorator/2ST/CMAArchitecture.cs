using System;
namespace DesignPattern.PatternModels.Decorator.ST
{
    public class CMAArchitecture
    {
        /// <summary>
        /// 底盘
        /// </summary>
        protected virtual void Chassis()
        {
            Console.WriteLine("Equiped a car chassis.");
        }

        /// <summary>
        /// 电气化
        /// </summary>
        protected virtual void Electrification()
        {
            Console.WriteLine("Equiped a car Electrification.");
        }

        /// <summary>
        /// 发动机
        /// </summary>
        protected virtual void Engine()
        {
            Console.WriteLine("Equiped a car Engine.");
        }

        /// <summary>
        /// 悬架
        /// </summary>
        protected virtual void Suspension()
        {
            Console.WriteLine("Equiped a car Suspension.");
        }

        public virtual void Create()
        {
            Chassis();
            Electrification();
            Engine();
            Suspension();
            Console.WriteLine("Prepar to create a new car...");
        }
    }
}
