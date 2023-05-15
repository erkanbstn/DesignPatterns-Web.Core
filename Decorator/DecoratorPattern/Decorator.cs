using Decorator.DAL;

namespace Decorator.DecoratorPattern
{
    public class Decorator : INotifier
    {
        private readonly INotifier _notifier;
        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        virtual public void CreateNotifier(Notifier notifier)
        {
            notifier.Creater = "Admin";
            notifier.Subject = "Toplantı";
            notifier.Type = "Public";
            notifier.Channel = "Whatsapp";
            _notifier.CreateNotifier(notifier);
        }
    }
}
