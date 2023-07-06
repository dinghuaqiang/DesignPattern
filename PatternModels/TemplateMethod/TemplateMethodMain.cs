using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.TemplateMethod
{
    /// <summary>
    /// C#中的模板方法模式是一种行为型设计模式，它允许定义一个算法的框架，并在不改变该算法结构的情况下，通过子类来重新定义算法的某些步骤。
    /// 在C#中，实现模板方法模式通常需要以下步骤：
    /// 1.	创建一个抽象基类，定义算法的框架，包含一些具体方法和抽象方法。
    /// 2.	在抽象基类中定义一个模板方法，该方法定义了算法的框架，包含一些具体步骤和调用抽象方法的步骤。
    /// 3.	创建一个或多个具体子类，实现抽象基类中的抽象方法。
    /// 4.	在具体子类中，可以选择性地覆盖模板方法中的某些步骤，以实现特定的行为。
    /// 
    /// 优点：
    /// 封装不变部分，扩展可变部分
    /// 提取公共部分代码，便于维护
    /// 行为由父类控制，子类实现
    /// 
    /// 应用场景：
    /// 1. 一次性实现一个算法的不变的部分，并将可变的行为留给子类来实现。 2. 各子类中公共的行为被提取出来并集中到一个公共的父类中，从而避免代码重复。
    /// </summary>
    internal class TemplateMethodMain
    {
        //private static void Main(string[] args) 
        //{
        //    AndroidUpdate androidUpdate = new AndroidUpdate();
        //    androidUpdate.Update();

        //    Console.WriteLine("---------------------------------------------------------");

        //    IOSUpdate iosUpdate = new IOSUpdate();
        //    iosUpdate.Update();

        //    Console.ReadLine();
        //}
    }
}
