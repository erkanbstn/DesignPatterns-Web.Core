using Observer.DAL;
using System;

namespace Observer.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider serviceProvider_;

        public CreateMagazineAnnouncement(IServiceProvider serviceProvider_)
        {
            this.serviceProvider_ = serviceProvider_;
        }

        Context context = new Context();

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Dergisi.",
                Content = "Bilim Dergimizin Mart Sayısı 1 Martta Evinize Ulaştırılacaktır."
            });
            context.SaveChanges();
        }
    }
}
