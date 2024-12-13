namespace DecoratorPatternApp.Models
{
    public interface IComponent<T>
    {
        T GetText();
    }
}