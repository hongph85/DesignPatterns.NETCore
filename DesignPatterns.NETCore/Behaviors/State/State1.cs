using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.State
{
    class State1 : IState
    {
        private Context context;

        public void Execute()
        {
            // do something
            Console.WriteLine($"State is {nameof(State1)}");

            // and update state to State2
            State2 state = new State2();
            state.SetContext(context);
            context.ChangeState(state);
        }

        public void SetContext(Context context)
        {
            this.context = context;
        }
    }
}
