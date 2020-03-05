using System;

namespace CSOOPPatterns.Structural.Bridge
{
    public class BridgeClient
    {
        public void DoStuff()
        {
            var fireStaff = new FireStaff();
            var iceStaff = new IceStaff();
            
            var orcWarlock = new OrcWarlock();
            var humanWizard = new HumanWizard();
            
            orcWarlock.Staff = fireStaff;
            Console.Write($"{orcWarlock.GetType().Name}: ");
            orcWarlock.Attack();
            orcWarlock.Staff = iceStaff;
            orcWarlock.Help();
            Console.WriteLine();
            
            humanWizard.Staff = iceStaff;
            Console.Write($"{humanWizard.GetType().Name}: ");
            humanWizard.Attack();
            humanWizard.Staff = fireStaff;
            humanWizard.Help();
            Console.WriteLine();
        }
    }
}