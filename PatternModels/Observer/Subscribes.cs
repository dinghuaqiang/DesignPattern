using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Observer
{
    public class Subscribes : Subject
    {
        private List<Observer> _observes = new List<Observer>();

        public void Notify(string msg)
        {
            for (int i = 0; i < _observes.Count; i++)
            {
                _observes[i].Nofify(msg);
            }
        }

        public void Subscribe(Observer observer)
        {
            _observes.Add(observer);
        }

        public void UnSubscribe(Observer observer)
        {
            _observes.Remove(observer);
        }
    }
}
