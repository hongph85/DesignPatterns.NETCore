using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Template
{
    class Context
    {
        public BaseTemplate Template
        {
            get; set;
        }

        public void Execute()
        {
            if (Template.Step1())
                Template.Step2();

            if (Template.Step3())
                Template.Step4();
        }
    }
}
