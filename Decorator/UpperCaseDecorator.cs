using Design_Decorator.IComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Decorator.Decorator
{
    // UpperCaseDecorator.cs
    public class UpperCaseDecorator : Decorator<string>
    {
        public UpperCaseDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            return base.GetText().ToUpper();
        }
    }

}
