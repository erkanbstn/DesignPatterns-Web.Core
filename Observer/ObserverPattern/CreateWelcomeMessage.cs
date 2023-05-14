using Observer.DAL;
using System;

namespace Observer.ObserverPattern
{
    public class CreateWelcomeMessage:IObserver
    {
        private readonly IServiceProvider serviceProvider_;

        public CreateWelcomeMessage(IServiceProvider serviceProvider_)
        {
            this.serviceProvider_ = serviceProvider_;
        }

        Context context = new Context();

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content="Dergi Bültenimize Kaydolduğunuz İçin Çok Teşekkür Ederiz. Web Sitemizden Dergilerimize Ulaşabilirsiniz."
            }) ;
            context.SaveChanges();
        }
    }
}
