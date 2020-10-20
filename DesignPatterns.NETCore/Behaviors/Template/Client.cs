using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Template
{
    public class Client : ICommand
    {
        public void Execute()
        {
            var context = new Context();
            context.Template = new Template1();
            context.Execute();

            context.Template = new Template2();
            context.Execute();
        }
    }
}