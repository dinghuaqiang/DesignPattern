using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.OOP.Base
{
    /// <summary>
    /// 抽象类是对对象的抽象
    /// </summary>
    public abstract class Tree
    {
        /// <summary>
        /// 树叶数量
        /// </summary>
        protected int LeafCount = 0;

        /// <summary>
        /// 树叶颜色
        /// </summary>
        protected Color LeafColor = Color.Green;

        /// <summary>
        /// 树的品种
        /// </summary>
        protected string Category = string.Empty;

        /// <summary>
        /// 树苗发芽
        /// </summary>
        protected abstract void Germinate();

        /// <summary>
        /// 树叶发芽
        /// </summary>
        protected abstract void LeafGrow();

        /// <summary>
        /// 落叶
        /// </summary>
        protected abstract void LeafFall();
    }
}
