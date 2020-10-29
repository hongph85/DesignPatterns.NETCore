namespace DesignPatterns.NETCore.Behaviors.Iterator
{
    interface Iterator
    {
        Person GetNext();
        bool HasMore();
    }
}
