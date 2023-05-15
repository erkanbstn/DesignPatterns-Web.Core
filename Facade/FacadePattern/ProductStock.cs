using Facade.DAL;

namespace Facade.FacadePattern
{
    public class ProductStock
    {
        private readonly Context _context;

        public ProductStock(Context context)
        {
            _context = context;
        }

        public void StockDecrease(int id,int amount)
        {
            var value = _context.Products.Find(id);
            value.Stock -= amount;
            _context.SaveChanges();
        }
    }
}
