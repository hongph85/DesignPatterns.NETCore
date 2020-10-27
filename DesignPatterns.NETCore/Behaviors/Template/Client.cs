using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Template
{
    public class Client : ICommand
    {
        public void Execute()
        {
            var context = new Context();
            context.DoSomeThing(new Template1());
        }
    }
}