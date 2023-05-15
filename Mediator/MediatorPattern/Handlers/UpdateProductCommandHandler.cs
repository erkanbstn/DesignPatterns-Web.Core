using Mediator.DAL;
using Mediator.MediatorPattern.Commands;
using MediatR;

namespace Mediator.MediatorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.ProductId);
            values.Name = request.Name;
            values.Stock = request.Stock;
            values.Price = request.Price;
            values.StockType = request.StockType;
            values.Category = request.Category;
            await _context.SaveChangesAsync();
        }
    }
}
