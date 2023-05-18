using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.OOP.Base.IterfaceDefines
{

    /// <summary>
    /// 接口是对对象行为的抽象
    /// 观赏树的行为
    /// </summary>
    public interface IOrnamentalTree
    {
        /// <summary>
        /// 快速生长
        /// </summary>
        void GrowFaster();

        /// <summary>
        /// 颜色改变
        /// </summary>
        void ChangeColor();
    }
}
