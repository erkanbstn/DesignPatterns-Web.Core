using Facade.DAL;

namespace Facade.FacadePattern
{
    public class AddOrderDetail
    {
        private readonly Context _context;

        public AddOrderDetail(Context context)
        {
            _context = context;
        }

        public void AddNewOrderDetail(OrderDetail orderdetail)
        {
            _context.OrderDetails.Add(orderdetail);
            _context.SaveChanges();
        }
    }
}
