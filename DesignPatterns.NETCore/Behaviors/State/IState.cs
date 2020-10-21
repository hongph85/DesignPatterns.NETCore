using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.State
{
    interface IState
    {
        void Execute();
        void SetContext(Context context);
    }
}
