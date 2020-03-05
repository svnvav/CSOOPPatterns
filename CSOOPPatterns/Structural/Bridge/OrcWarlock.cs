using System;

namespace CSOOPPatterns.Structural.Bridge
{
    public class OrcWarlock : Mage
    {
        public override void Attack()
        {
            Console.Write("Лок тар огар ");
            _staff.Damage();
        }

        public override void Help()
        {
            _staff.Buff();
            Console.Write(" поможет убить врага");
        }
    }
}