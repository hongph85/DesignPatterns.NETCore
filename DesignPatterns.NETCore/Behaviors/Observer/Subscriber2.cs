using System;

namespace DesignPatterns.NETCore.Behaviors.Observer
{
    public class Subscriber2 : ISubscriber
    {
        public void Update(string data)
        {
            Console.WriteLine($"{nameof(Subscriber2)} received data {data}");
        }
    }
}