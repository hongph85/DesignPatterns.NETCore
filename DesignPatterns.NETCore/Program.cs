using DesignPatterns.NETCore.Behaviors.Template;
using System;

namespace DesignPatterns.NETCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Template Pattern:");
            Console.WriteLine("Using template 1");
            var command = new Client() { Template = new Template1() };
            command.Execute();

            Console.ReadLine();
        }
    }
}
