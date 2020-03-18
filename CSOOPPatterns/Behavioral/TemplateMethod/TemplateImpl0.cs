namespace CSOOPPatterns.Behavioral.TemplateMethod
{
    public class TemplateImpl0 : TemplateBase
    {
        protected override string Step1()
        {
            return $"{GetType().Name} step1 ";
        }
    }
}