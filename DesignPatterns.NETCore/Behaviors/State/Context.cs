namespace DesignPatterns.NETCore.Behaviors.State
{
    class Context
    {
        private IState state;

        public Context()
        {
            this.state = new State1();
            this.state.SetContext(this);
        }

        public void DoSomeThing()
        {
            state.Execute();
        }

        /// <summary>
        /// the concrete states update context by using this function
        /// </summary>
        /// <param name="state"></param>
        public void ChangeState(IState state)
        {
            this.state = state;
        }
    }
}
