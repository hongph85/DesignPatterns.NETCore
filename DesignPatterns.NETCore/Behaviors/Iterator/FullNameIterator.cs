using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.NETCore.Behaviors.Iterator
{
    class FullNameIterator : Iterator
    {
        MyFamilly collection;
        int currentPos;
        List<Person> cache;
        public FullNameIterator(MyFamilly collection)
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
                cache = collection.OrderBy(i => i.FullName).ToList();
            }

            return currentPos < collection.Count;
        }
    }
}
