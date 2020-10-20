using System;

namespace DesignPatterns.NETCore.Behaviors.Strategy
{
    class Strategy1 : IStrategy
    {
        public int Execute(string p)
        {
            Console.WriteLine($"{nameof(Strategy1)} execute with parameter value '{p}'");
            return p.Length;
        }
    }
}
