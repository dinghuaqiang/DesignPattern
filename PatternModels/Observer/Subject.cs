using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Observer
{
    /// <summary>
    /// 被观察的抽象
    /// </summary>
    public interface Subject
    {
        /// <summary>
        /// 增加订阅
        /// </summary>
        void Subscribe(Observer observer);
        /// <summary>
        /// 取消订阅
        /// </summary>
        void UnSubscribe(Observer observer);
        /// <summary>
        /// 通知订阅者消息
        /// </summary>
        /// <param name="msg"></param>
        void Notify(string msg);
    }
}
