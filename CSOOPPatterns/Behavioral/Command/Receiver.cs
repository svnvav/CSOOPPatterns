using System;

namespace CSOOPPatterns.Behavioral.Command
{
    public class Receiver
    {
        public void DoStuff(string param)
        {
            Console.WriteLine(param);
        }
    }
}