namespace CSOOPPatterns.AbstractFactory
{
    public interface UnitFactory
    {
        IWarrior GetWarrior();

        ISiege GetSiege();
    }
}