using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Iterator
{
    interface IterableCollection
    {
        Iterator GetFullNameIterator();
    }
}
