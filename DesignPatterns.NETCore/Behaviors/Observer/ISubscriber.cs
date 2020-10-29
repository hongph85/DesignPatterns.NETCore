using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Observer
{
    public interface ISubscriber
    {
        void Update(string data);
    }
}