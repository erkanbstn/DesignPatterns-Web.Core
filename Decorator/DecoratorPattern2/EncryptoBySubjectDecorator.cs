using Decorator.DAL;

namespace Decorator.DecoratorPattern2
{
    public class EncryptoBySubjectDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptoBySubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SendMessageByEncryptoSubject(Message message)
        {
           
            string data = "";
            data = message.Subject;
            char[] chars = data.ToCharArray();
            foreach (char c in chars)
            {
                message.Subject += Convert.ToChar(c + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoSubject(message); 
        }
    }
}
