namespace CSOOPPatterns.Behavioral.TemplateMethod
{
    public class TemplateImpl1 : TemplateBase
    {
        protected override string Step0()
        {
            return $"{GetType().Name} step0 ";
        }
        
        protected override string Step1()
        {
            return $"{GetType().Name} step1 ";
        }
    }
}