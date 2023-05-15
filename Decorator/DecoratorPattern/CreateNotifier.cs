using Decorator.DAL;

namespace Decorator.DecoratorPattern
{
    public class CreateNotifier : INotifier
    {
        Context context = new Context();
        void INotifier.CreateNotifier(Notifier notifier)
        {
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }
    }
}
