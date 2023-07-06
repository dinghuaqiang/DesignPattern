using System;

namespace DesignPattern.PatternModels.Build
{
    /// <summary>
    /// 建造者模式
    /// 主要是用于创建一些复杂的对象，这些对象内部构建的建造顺序通常是稳定的，但对象内部的构建通常面临复杂的变化。
    /// Builder， 抽象建造者 为创建产品各个部分，统一抽象接口
    /// Director，指挥者 构造一个使用Builder接口的对象 它主要是用于创建一个复杂的对象。 它主要有两个作用，一是：隔离了客户与对象的生产过程，二是：负责控制产品对象的生产过程。
    /// 
    /// 工厂模式：  创建不同但是相关类型的对象(继承同一父类或接口的一组子类)，由给定的参数决定创建哪种类型的对象。
    /// 建造者模式：创建一种类型的复杂对象，通过设置不同的参数，"定制化"地创建不同的对象。
    /// 
    /// 建造者模式所创建的产品一般具有较多的共同点，其组成部分相似，如果产品之间的差异性较大，则不适合使用建造者模式，因此其使用范围受到一定的限制。
    /// </summary>
    public class BuildMain
    {
        private static void Main(string[] args)
        {
            ItemDirector director = new ItemDirector(new EquipItem(1, "头盔"));
            director.BuildItem();
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
