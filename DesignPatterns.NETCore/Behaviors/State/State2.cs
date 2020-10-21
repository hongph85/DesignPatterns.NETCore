using System;

namespace DesignPatterns.NETCore.Behaviors.State
{
    class State2 : IState
    {
        private Context context;

        public void Execute()
        {
            // and do something
            Console.WriteLine($"State is {nameof(State2)}");
        }

        public void SetContext(Context context)
        {
            this.context = context;
        }
    }
}
