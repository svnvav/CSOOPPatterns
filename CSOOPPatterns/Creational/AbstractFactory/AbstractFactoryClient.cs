namespace CSOOPPatterns.AbstractFactory
{
    public class AbstractFactoryClient
    {
        private UnitFactory _unitFactory;

        public AbstractFactoryClient(UnitFactory unitFactory)
        {
            _unitFactory = unitFactory;
        }

        public void SetUnitFactory(UnitFactory unitFactory)
        {
            _unitFactory = unitFactory;
        }

        public void DoSquad()
        {
            var warrior = _unitFactory.GetWarrior();
            var siege = _unitFactory.GetSiege();
            
            warrior.MakeWar();
            siege.Beseige();
        }
    }
}