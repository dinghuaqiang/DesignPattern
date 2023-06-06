using System;
using DesignPattern.PatternModels.Decorator.ST;

namespace DesignPattern.PatternModels.Decorator
{
    /// <summary>
    /// 装饰模式的实验
    /// 动态的给对象添加一些额外的职责，就增加功能来说比新增子类更加灵活
    /// 是一种为已有功能动态添加更多功能的一种方式
    ///
    /// 具体操作就是一个 【具体实现类】去实现基本的功能，【装饰类】接收传递的子类执行函数， 子类添加自己需要扩展的属性
    ///
    /// 行为树其实就是典型的装饰模式
    /// </summary>
    public class DecoratorMain
    {
        /*public static void Main(string[] args)
        {
            ConcrateComponent cc = new ConcrateComponent();
            ConcrateDecoratorA cda = new ConcrateDecoratorA();
            ConcrateDecoratorB cdb = new ConcrateDecoratorB();

            //相当于是附加到一个调用链上去
            cda.SetComponent(cc);
            cdb.SetComponent(cda);
            cdb.Operation();

            Console.ReadKey();
        }*/

        //public static void Main(string[] args)
        //{
        //    CMAArchitecture manufacturer = new CMAArchitecture();
        //    SUV suv = new SUV();
        //    suv.ApplyArch(manufacturer);
        //    suv.Create();
        //    Console.WriteLine("----------------------------------------------------------");
        //    MPV mpv = new MPV();
        //    mpv.ApplyArch(manufacturer);
        //    mpv.Create();

        //    Console.ReadKey();
        //}
    }
}
