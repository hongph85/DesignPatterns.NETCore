using System;

namespace DesignPatterns.NETCore.Behaviors.Observer
{
    public class Subscriber1 : ISubscriber
    {
        public void Update(string data)
        {
            Console.WriteLine($"{nameof(Subscriber1)} received data {data}");
        }
    }
}