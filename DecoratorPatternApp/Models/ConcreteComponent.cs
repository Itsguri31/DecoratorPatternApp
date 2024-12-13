namespace DecoratorPatternApp.Models
{
    public class ConcreteComponent : IComponent<string>
    {
        public string GetText()
        {
            return "Hello, World!";
        }
    }
}