namespace CSOOPPatterns.AbstractFactory
{
    public class HumanUnitFactory : UnitFactory
    {
        public IWarrior GetWarrior()
        {
            return new HumanInfantry();
        }

        public ISiege GetSiege()
        {
            return new HumanTrembling();
        }
    }
}