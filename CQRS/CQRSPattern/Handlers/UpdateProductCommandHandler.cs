using CQRS.CQRSPattern.Commands;
using CQRS.DAL;

namespace CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand updateProductCommand)
        {
            var values = _context.Products.Find(updateProductCommand.ProductId);
            values.Name = updateProductCommand.Name;
            values.Description = updateProductCommand.Description;
            values.Price = updateProductCommand.Price;
            values.Stock = updateProductCommand.Stock;
            values.Status = true;
            _context.SaveChanges();
        }
    }
}
