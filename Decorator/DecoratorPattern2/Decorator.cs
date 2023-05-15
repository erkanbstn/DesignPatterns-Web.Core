using Decorator.DAL;

namespace Decorator.DecoratorPattern2
{
    public class Decorator : ISendMessage
    {
        private readonly ISendMessage _sendMessage;

        public Decorator(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

        virtual public void SendMessage(Message message)
        {
            message.Receiver = "Everbody";
            message.Sender = "Admin";
            message.Content = "Toplantı Mesajı";
            message.Subject= "Toplantı";
            _sendMessage.SendMessage(message);
        }
    }
}
