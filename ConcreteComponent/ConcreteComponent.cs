using Design_Decorator.IComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Decorator.ConcreteComponent
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Ankita here!I am currently studying Mobile Application in cambrian college Arts and Technology.";
        }
    }

}
