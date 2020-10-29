using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Iterator
{
    class Client : ICommand
    {
        public void Execute()
        {
            var persons = new List<Person>()
            {
                new Person("Hong", 34),
                new Person("Dau", 2),
                new Person("Trang", 28),
            };
            var iterableCollection = new MyFamilly(persons);

            // Interate by full name
            Console.WriteLine("Iterate by full name");
            var iterator = iterableCollection.GetFullNameIterator();
            Print(iterator);

            Console.WriteLine("Iterate by age");
            var iterator2 = iterableCollection.GetAgeIterator();
            Print(iterator2);
        }

        private static void Print(Iterator iterator)
        {
            while (iterator.HasMore())
            {
                var result = iterator.GetNext();
                Console.WriteLine($"Person name: {result.FullName}");
            }
        }
    }
}
