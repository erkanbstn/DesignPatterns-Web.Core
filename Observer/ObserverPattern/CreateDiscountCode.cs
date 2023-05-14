using Observer.DAL;
using System;

namespace Observer.ObserverPattern
{
    public class CreateDiscountCode:IObserver
    {
        private readonly IServiceProvider serviceProvider_;

        public CreateDiscountCode(IServiceProvider serviceProvider_)
        {
            this.serviceProvider_ = serviceProvider_;
        }

        Context context = new Context();

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                Code="Dergimart",
                Amount=35,
                Status=true
            });
            context.SaveChanges();
        }
    }
}
