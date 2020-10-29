using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Observer
{
    class Client : ICommand
    {
        public void Execute()
        {
            var publisher = new Publisher();
            var sub1 = new Subscriber1();
            var sub2 = new Subscriber2();
            publisher.Register(sub1);
            publisher.Register(sub2);

            publisher.Notify("Hello");


        }
    }
}
