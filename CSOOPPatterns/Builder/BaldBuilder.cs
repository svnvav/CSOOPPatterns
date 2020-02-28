using CSOOPPatterns.Builder.Unit;

namespace CSOOPPatterns.Builder
{
    public class BaldBuilder : UnitBuilder
    {
        private SectionalUnit _result;
        
        public void Reset()
        {
            _result = new SectionalUnit();
        }

        public void SetHead()
        {
            _result.SetHead(new BaldHead());
        }

        public void SetLegs()
        {
            _result.SetLeftLeg(new BaldLeg());
            _result.SetLeftLeg2(new BaldLeg());
        }

        public SectionalUnit GetResult()
        {
            return _result;
        }
    }
}