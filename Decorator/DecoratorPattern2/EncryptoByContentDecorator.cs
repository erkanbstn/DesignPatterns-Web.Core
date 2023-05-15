using Decorator.DAL;

namespace Decorator.DecoratorPattern2
{
    public class EncryptoByContentDecorator:Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptoByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }
        public void SendMessageByEncryptoContent(Message message)
        {
            message.Sender = "Takım Lideri";
            message.Receiver = "Yazılım Ekibi";
            message.Content = "Saat 17'de Publish Yapılacak";
            message.Subject = "Publish";
            string data = "";
            data = message.Content;
            char[] chars = data.ToCharArray();
            foreach (char c in chars)
            {
                message.Content += Convert.ToChar(c + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoContent(message);
        }
    }
}
