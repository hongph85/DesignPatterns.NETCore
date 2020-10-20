using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Template
{
    public class Client : ICommand
    {
        public BaseTemplate Template
        {
            get;set;
        }

        public void Execute()
        {
            if (Template.Step1())
                Template.Step1();

            if (Template.Step3())
                Template.Step4();
        }
    }
}