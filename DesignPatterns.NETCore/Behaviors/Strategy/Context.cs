using System;

namespace DesignPatterns.NETCore.Behaviors.Strategy
{
    internal class Context
    {
        private IStrategy strategy;
        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Run(string parameter)
        {
            // execute strategy funciton
            var result = strategy.Execute(parameter);

            // and do some logic here
            Console.WriteLine($"Execute successfully with value returned '{result}'");
        }
    }
}
