using CSOOPPatterns.Builder.Unit;

namespace CSOOPPatterns.Builder
{
    public interface UnitBuilder
    {
        void Reset();

        void SetHead();
        void SetLegs();

        SectionalUnit GetResult();
    }
}