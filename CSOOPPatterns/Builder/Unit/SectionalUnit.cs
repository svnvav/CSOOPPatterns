using System;

namespace CSOOPPatterns.Builder.Unit
{
    public class SectionalUnit
    {
        private IHead _head;
        private ILeg _leftLeg, _leftLeg2;

        public void SetHead(IHead head)
        {
            _head = head;
        }

        public void SetLeftLeg(ILeg leg)
        {
            _leftLeg = leg;
        }
        
        public void SetLeftLeg2(ILeg leg)
        {
            _leftLeg2 = leg;
        }

        public void DoStuff()
        {
            Console.Write($"{GetType().Name}: *бежит на ");
            _leftLeg.Run();
            Console.Write(" и ");
            _leftLeg2.Run();
            Console.Write(", орёт с помощью ");
            _head.Yell();
            Console.WriteLine('*');
        }
    }
}