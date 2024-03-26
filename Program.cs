using Design_Decorator.ConcreteComponent;
using Design_Decorator.Decorator;
using Design_Decorator.IComponent;

IComponent<string> component = new ConcreteComponent();

// Create decorators
var plainDecorator = new PlainDecorator(component);
var upperCaseDecorator = new UpperCaseDecorator(component);
var colorDecorator = new ColorDecorator(component);

// Call GetText() on each object and print the result to the console
Console.WriteLine("First: " + component.GetText());

Console.WriteLine("PlainDecorator: " + plainDecorator.GetText());
Console.WriteLine("UpperCaseDecorator: " + upperCaseDecorator.GetText());
Console.WriteLine("ColorDecorator: " + colorDecorator.GetText());