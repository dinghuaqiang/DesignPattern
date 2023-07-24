using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Observer
{
    internal class NeedNoftiyObserver : Observer
    {
        private string _name;

        public NeedNoftiyObserver(string name) 
        {
            _name = name;
        }

        public void Nofify(string noticeMsg)
        {
            Console.WriteLine(string.Format("The {0} received a notifiy message that is {1}", _name, noticeMsg));
        }
    }
}
