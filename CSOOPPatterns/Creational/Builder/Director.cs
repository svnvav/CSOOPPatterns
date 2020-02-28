using CSOOPPatterns.Builder.Unit;

namespace CSOOPPatterns.Builder
{
    public class Director
    {
        private UnitBuilder _builder;

        public Director(UnitBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(UnitBuilder builder)
        {
            _builder = builder;
        }
        
        public SectionalUnit GetUnit()
        {
            _builder.Reset();
            _builder.SetHead();
            _builder.SetLegs();
            return _builder.GetResult();
        }
    }
}