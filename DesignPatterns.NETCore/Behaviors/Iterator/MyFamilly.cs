using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.NETCore.Behaviors.Iterator
{
    class MyFamilly : IterableCollection, IEnumerable<Person>
    {
        List<Person> persons;

        public MyFamilly(List<Person> persons)
        {
            this.persons = persons;
        }

        public Iterator GetFullNameIterator()
        {
            return new FullNameIterator(this);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return persons.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return persons.GetEnumerator();
        }

        public Iterator GetAgeIterator()
        {
            return new AgeIterator(this);
        }

        public Person this[int index] {
            get
            {
                return persons[index];
            }
        }

        public int Count
        {
            get
            {
                return persons.Count;
            }
        }
    }
}
