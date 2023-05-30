using System;
namespace DesignPattern.PatternModels.Decorator.ST
{
    public class CarDecorate : CMAArchitecture
    {
        protected CMAArchitecture _cmaArchitecture;

        public void ApplyArch(CMAArchitecture architecture)
        {
            _cmaArchitecture = architecture;
        }

        public override void Create()
        {
            if (_cmaArchitecture != null)
            {
                _cmaArchitecture.Create();
            }
        }
    }
}
