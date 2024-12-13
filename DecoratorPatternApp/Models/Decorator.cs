namespace DecoratorPatternApp.Models
{
    public abstract class Decorator<T> : IComponent<T>
    {
        protected readonly IComponent<T> component;

        public Decorator(IComponent<T> component)
        {
            this.component = component;
        }

        public virtual T GetText()
        {
            return component.GetText();
        }
    }
}