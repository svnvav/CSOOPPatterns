namespace CSOOPPatterns.Behavioral.Strategy
{
    public class Strategy0 : IStrategy
    {
        public string Execute()
        {
            return GetType().Name;
        }
    }
}