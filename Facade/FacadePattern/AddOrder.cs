using Facade.DAL;

namespace Facade.FacadePattern
{
    public class AddOrder
    {
        private readonly Context _context;

        public AddOrder(Context context)
        {
            _context = context;
        }

        public void AddNewOrder(Order order)
        {
            order.OrderDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
