namespace CSOOPPatterns.Behavioral.TemplateMethod
{
    public class TemplateMethodClient
    {
        private TemplateBase _template;
        
        public void DoStuff()
        {
            _template = new TemplateImpl0();
            _template.Execute();
            
            _template = new TemplateImpl1();
            _template.Execute();
        }
    }
}