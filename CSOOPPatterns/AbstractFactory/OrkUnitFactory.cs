namespace CSOOPPatterns.AbstractFactory
{
    public class OrkUnitFactory : UnitFactory
    {
        public IWarrior GetWarrior()
        {
            return new OrkBerserk();
        }

        public ISiege GetSiege()
        {
            return new OrcCatapult();
        }
    }
}