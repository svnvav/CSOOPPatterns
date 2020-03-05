using System;

namespace CSOOPPatterns.Structural.Bridge
{
    public class HumanWizard : Mage
    {
        public override void Attack()
        {
            Console.Write("Здохне от ");
            _staff.Damage();
        }

        public override void Help()
        {
            _staff.Buff();
            Console.Write(" поможет выжить");
        }
    }
}