namespace CSOOPPatterns.Behavioral.Strategy
{
    public class StrategyClient
    {
        public void DoStuff()
        {
            var context = new StrategyContext(new Strategy0());
            context.Execute();
            
            context.SetStrategy(new Strategy1());
            context.Execute();
        }
    }
}