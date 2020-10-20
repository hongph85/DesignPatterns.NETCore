using System;

namespace DesignPatterns.NETCore.Behaviors.Strategy
{
    class Client : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Use strategy 1");
            IStrategy strategy = new Strategy1();
            var context = new Context();
            context.SetStrategy(strategy);
            context.Run("Hello everyone!");

            Console.WriteLine("Use strategy 2");
            strategy = new Strategy2();
            context.SetStrategy(strategy);
            context.Run("Hello everyone!");
        }
    }
}
