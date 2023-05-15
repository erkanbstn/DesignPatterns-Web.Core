using Mediator.DAL;
using Mediator.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace Mediator.MediatorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.AddAsync(new Product
            {
                Name = request.Name,
                Stock = request.Stock,
                Price = request.Price,
                StockType = request.StockType,
                Category = request.Category,
            });
            await _context.SaveChangesAsync();
        }
    }
}
