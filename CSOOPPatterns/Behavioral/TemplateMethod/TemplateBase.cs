using System;

namespace CSOOPPatterns.Behavioral.TemplateMethod
{
    public abstract class TemplateBase
    {
        public void Execute()
        {
            Console.WriteLine(Step0());
            Console.WriteLine(Step1());
        }

        protected virtual string Step0()
        {
            return "Base step0";
        }

        protected abstract string Step1();
    }
}