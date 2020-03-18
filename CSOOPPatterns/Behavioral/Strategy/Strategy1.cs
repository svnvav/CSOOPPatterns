namespace CSOOPPatterns.Behavioral.Strategy
{
    public class Strategy1 : IStrategy
    {
        public string Execute()
        {
            return GetType().Name;
        }
    }
}