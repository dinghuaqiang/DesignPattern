using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.OOP.Base.IterfaceDefines
{
    /// <summary>
    /// 果树的行为
    /// </summary>
    public interface IFruitTree
    {
        /// <summary>
        /// 开花
        /// </summary>
        void Flower();

        /// <summary>
        /// 结果子
        /// </summary>
        void BearFruit();
    }
}
