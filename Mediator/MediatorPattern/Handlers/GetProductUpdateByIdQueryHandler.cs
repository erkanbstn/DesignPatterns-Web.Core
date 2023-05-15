using Mediator.DAL;
using Mediator.MediatorPattern.Queries;
using Mediator.MediatorPattern.Results;
using MediatR;

namespace Mediator.MediatorPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler : IRequestHandler<Test, UpdateProductByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<UpdateProductByIdQueryResult> Handle(Test request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.Id);
            return new UpdateProductByIdQueryResult
            {
                Category = value.Category,
                ProductId = value.ProductId,
                Name = value.Name,
                Price = value.Price,
                Stock = value.Stock,
                StockType = value.StockType
            };
        }
    }
}
