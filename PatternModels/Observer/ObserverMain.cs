using System;
using static System.Collections.Specialized.BitVector32;

namespace DesignPattern.PatternModels.Observer
{
    /// <summary>
    /// 观察者模式
    /// 当一个对象的改变需要同时改变其他对象，而且它不知道具体有多少对象有待改变，这个时候用
    /// 它所做的工作就是在解耦合，让耦合的双方都依赖于抽象，而不是依赖于具体。从而使得各自的变化都不会影响到另一边的变化。
    /// </summary>
    public class ObserverMain
    {
        private string name;
        private string pwd;
        private static void Main(string[] args)
        {
            NeedNoftiyObserver observerWaitter = new NeedNoftiyObserver("Waitter");
            NeedNoftiyObserver observerChef = new NeedNoftiyObserver("Chef");

            Subscribes subs = new Subscribes();
            subs.Subscribe(observerWaitter);
            subs.Subscribe(observerChef);

            subs.Notify("青椒肉丝");
            subs.Notify("水煮肉片");
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
