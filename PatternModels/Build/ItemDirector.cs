using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Build
{
    public class ItemDirector
    {
        private ItemBuilder _builder = null;
        public ItemDirector(ItemBuilder builder) 
        {
            _builder = builder;
        }

        public void BuildItem() 
        {
            _builder.BuildIcon();
            _builder.BuildQuality();
            _builder.BuildSize();
            _builder.BuildDesc();
        }
    }
}
