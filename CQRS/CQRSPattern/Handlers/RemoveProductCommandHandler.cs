using CQRS.CQRSPattern.Commands;
using CQRS.DAL;

namespace CQRS.CQRSPattern.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveProductCommand removeProductCommand)
        {
            var values = _context.Products.Find(removeProductCommand.ProductId);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }
    }
}
