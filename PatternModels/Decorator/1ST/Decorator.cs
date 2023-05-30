using System;
namespace DesignPattern.PatternModels.Decorator.ST
{
    public class Decorator : Component
    {
        protected Component _component;

        /// <summary>
        /// 设置组件
        /// </summary>
        public void SetComponent(Component component)
        {
            _component = component;
        }

        /// <summary>
        /// 执行操作
        /// </summary>
        public override void Operation()
        {
            if (_component != null)
            {
                _component.Operation();
            }
        }
    }
}
