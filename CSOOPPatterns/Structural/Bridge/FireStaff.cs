using System;

namespace CSOOPPatterns.Structural.Bridge
{
    public class FireStaff : IWizardStaff
    {
        public void Damage()
        {
            Console.Write("Fireball ");
        }

        public void Buff()
        {
            Console.Write(" Воспламеняющее оружие");
        }
    }
}