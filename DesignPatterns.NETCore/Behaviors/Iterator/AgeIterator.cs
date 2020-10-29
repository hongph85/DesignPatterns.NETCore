using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.NETCore.Behaviors.Iterator
{
    class AgeIterator : Iterator
    {
        MyFamilly collection;
        List<Person> cache;
        int currentPos;
        public AgeIterator(MyFamilly collection)
        {
            this.collection = collection;
        }

        public Person GetNext()
        {
            if (HasMore())
            {
                return cache[currentPos++];
            }

            return null;
        }

        public bool HasMore()
        {
            if (cache == null)
            {
                cache = this.collection.OrderBy(i => i.Age).ToList();
            }

            return currentPos < collection.Count;
        }
    }
}
