using Decorator.DAL;
using Decorator.DecoratorPattern2;
using Microsoft.AspNetCore.Mvc;

namespace Decorator.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult DecoratorIndex()
        {
            Message message = new Message();
            message.Content = "Test Content Mesajı";
            message.Sender = "Admin İK";
            message.Receiver = "Herkes";
            message.Subject = "Deneme";
            CreateNewMessage createNewMessage = new CreateNewMessage();
            createNewMessage.SendMessage(message);
            return View();
        }
        public IActionResult DecoratorIndex2()
        {
            CreateNewMessage createNewMessage = new CreateNewMessage();
            Message message = new Message();
            message.Sender = "İnsan Kaynakları";
            message.Receiver = "Yazılım Ekibi";
            message.Content = "Saat 12'de Toplantı Var";
            message.Subject = "Toplantı";
            EncryptoBySubjectDecorator encryptoBySubjectDecorator = new EncryptoBySubjectDecorator(createNewMessage);
            encryptoBySubjectDecorator.SendMessageByEncryptoSubject(message);
            return View();
        }
    }
}
