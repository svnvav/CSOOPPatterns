using System;

namespace CSOOPPatterns.Behavioral.Strategy
{
    public class StrategyContext
    {
        private IStrategy _strategy;

        public StrategyContext(IStrategy strategy)
        {
            _strategy = strategy;
        }
        
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Execute()
        {
            Console.WriteLine(_strategy.Execute());
        }
    }
}