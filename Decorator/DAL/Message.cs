namespace Decorator.DAL
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
