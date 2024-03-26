﻿using Design_Decorator.IComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Decorator.Decorator
{
    // ColorDecorator.cs
    public class ColorDecorator : Decorator<string>
    {
        public ColorDecorator(IComponent<string> component) : base(component)
        {
        }

        public override string GetText()
        {
            return $"\u001b[31m{base.GetText()}\u001b[0m"; // Red color ANSI code
        }
    }

}
