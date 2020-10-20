using System;

namespace DesignPatterns.NETCore.Behaviors.Template
{
    public class Template1 : BaseTemplate
    {
        public override void Step2()
        {
            Console.WriteLine($"{nameof(Template1)} step 2");
        }

        public override void Step4()
        {
            Console.WriteLine($"{nameof(Template1)} step 4");
        }
    }
}