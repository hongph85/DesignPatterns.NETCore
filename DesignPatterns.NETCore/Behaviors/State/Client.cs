using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.State
{
    class Client : ICommand
    {
        public void Execute()
        {

            var context = new Context();

            Console.WriteLine("Do something first time.");
            context.DoSomeThing();

            Console.WriteLine("Do something second time.");
            context.DoSomeThing();
        }
    }
}
