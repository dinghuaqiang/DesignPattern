using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Observer
{
    /// <summary>
    /// 抽象观察者
    /// </summary>
    public interface Observer
    {
        void Nofify(string noticeMsg);
    }
}
