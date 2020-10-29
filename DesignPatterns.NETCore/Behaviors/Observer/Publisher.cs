using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Observer
{
    public class Publisher
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();

        public void Notify(string data)
        {
            foreach(var sub in subscribers)
            {
                sub.Update(data);
            }
        }

        public void Register(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscriber(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
    }
}