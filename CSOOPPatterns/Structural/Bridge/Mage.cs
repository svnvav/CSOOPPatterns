namespace CSOOPPatterns.Structural.Bridge
{
    public abstract class Mage
    {
        protected IWizardStaff _staff;

        public IWizardStaff Staff
        {
            set => _staff = value;
        }

        public abstract void Attack();
        public abstract void Help();
    }
}