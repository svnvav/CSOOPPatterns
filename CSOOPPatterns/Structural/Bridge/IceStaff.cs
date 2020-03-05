using System;

namespace CSOOPPatterns.Structural.Bridge
{
    public class IceStaff : IWizardStaff
    {
        public void Damage()
        {
            Console.Write("Ice piece ");
        }

        public void Buff()
        {
            Console.Write(" Охлаждающий щит из углепластика");
        }
    }
}