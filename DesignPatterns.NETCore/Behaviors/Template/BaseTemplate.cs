using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NETCore.Behaviors.Template
{
    public abstract class BaseTemplate
    {
        public bool Step1()
        {
            Console.WriteLine($"{nameof(BaseTemplate)} Step 1");
            return true;
        }

        public abstract void Step2();

        public bool Step3()
        {
            return true;
        }

        public abstract void Step4();
    }
}