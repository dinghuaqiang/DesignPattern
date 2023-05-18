using DesignPattern.OOP.Base;
using DesignPattern.OOP.Base.IterfaceDefines;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.OOP
{

    /// <summary>
    /// 封装一个苹果树，继承树的属性，实现果树的行为
    /// </summary>
    public class AppleTree : Tree, IFruitTree
    {
        public AppleTree() 
        {
            //继承树的属性
            LeafCount = 1024;
            LeafColor = Color.Red;
        }

        public void BearFruit()
        {
            Console.WriteLine("AppleTree bear fruits!");
        }

        public void Flower()
        {
            Console.WriteLine("AppleTree grow Flowers!");
        }

        protected override void Germinate()
        {
            Console.WriteLine("AppleTree Germinate!");
        }

        protected override void LeafFall()
        {
            Console.WriteLine("AppleTree LeafFall!");
        }

        protected override void LeafGrow()
        {
            Console.WriteLine("AppleTree LeafGrow!");
        }
    }
}
