using CSOOPPatterns.Builder.Unit;

namespace CSOOPPatterns.Builder
{
    public class OpossumBuilder : UnitBuilder
    {
        private SectionalUnit _result;
        
        public void Reset()
        {
            _result = new SectionalUnit();
        }

        public void SetHead()
        {
            _result.SetHead(new OpossumHead());
        }

        public void SetLegs()
        {
            _result.SetLeftLeg(new OpossumLeg());
            _result.SetLeftLeg2(new OpossumLeg());
        }

        public SectionalUnit GetResult()
        {
            return _result;
        }
    }
}