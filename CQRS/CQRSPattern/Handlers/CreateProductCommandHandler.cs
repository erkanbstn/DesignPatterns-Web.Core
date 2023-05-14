using CQRS.CQRSPattern.Commands;
using CQRS.DAL;

namespace CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand createProductCommand)
        {
            _context.Products.Add(new Product
            {
                Description = createProductCommand.Description,
                Name = createProductCommand.Name,
                Price = createProductCommand.Price,
                Stock = createProductCommand.Stock,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
