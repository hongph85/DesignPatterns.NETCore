using System;

namespace DesignPatterns.NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Demo Template pattern
             */
            Console.WriteLine("1. Template Pattern:");
            Console.WriteLine("Using template 1");
            var command1 = new Behaviors.Template.Client();
            command1.Execute();

            /*
             * Demo strategy pattern
             */
            Console.WriteLine("\r\n2. Strategy Pattern:");
            var command2 = new Behaviors.Strategy.Client();
            command2.Execute();

            /*
             * Demo State pattern
             */
            Console.WriteLine("\r\n2. Strategy Pattern:");
            var command3 = new Behaviors.State.Client();
            command3.Execute();


            /*
             * Demo iterator
             */
            Console.WriteLine("\r\n3. Iterator Pattern:");
            var command4 = new Behaviors.Iterator.Client();
            command4.Execute();

            /*
             * Demo Observer
             */
            Console.WriteLine("\r\n3. Observer Pattern:");
            var command5 = new Behaviors.Observer.Client();
            command5.Execute();

            Console.ReadLine();
        }
    }
}
