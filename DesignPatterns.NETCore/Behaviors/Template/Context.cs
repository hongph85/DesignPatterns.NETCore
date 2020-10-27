using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Template
{
    class Context
    {
        public void DoSomeThing(BaseTemplate template)
        {
            if (template.Step1())
                template.Step2();
            if (template.Step3())
                template.Step4();
        }
    }
}
