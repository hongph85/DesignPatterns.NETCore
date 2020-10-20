using System;

namespace DesignPatterns.NETCore.Behaviors.Strategy
{
    class Strategy2 : IStrategy
    {
        public int Execute(string p)
        {
            Console.WriteLine($"{nameof(Strategy2)} execute with parameter value '{p}'");
            return p.Length;
        }
    }
}
