using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Template
{
    public class Client : ICommand
    {
        public void Execute()
        {
            var template = new Template1();
            DoSomeThing(template);

            var template2 = new Template2();
            DoSomeThing(template2);
        }

        private static void DoSomeThing(BaseTemplate template)
        {
            template.Step1();
            template.Step2();
            template.Step3();
            template.Step4();
        }
    }
}