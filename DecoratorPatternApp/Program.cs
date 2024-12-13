using System;
using DecoratorPatternApp.Models;

namespace DecoratorPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent<string> component = new ConcreteComponent();
            IComponent<string> plainDecorator = new PlainDecorator(component);
            IComponent<string> upperCaseDecorator = new UpperCaseDecorator(component);
            IComponent<string> colorDecorator = new ColorDecorator(component);

            Console.WriteLine("Original Text:");
            Console.WriteLine(component.GetText());

            Console.WriteLine("\nUsing PlainDecorator:");
            Console.WriteLine(plainDecorator.GetText());

            Console.WriteLine("\nUsing UpperCaseDecorator:");
            Console.WriteLine(upperCaseDecorator.GetText());

            Console.WriteLine("\nUsing ColorDecorator:");
            Console.WriteLine(colorDecorator.GetText());
        }
    }
}