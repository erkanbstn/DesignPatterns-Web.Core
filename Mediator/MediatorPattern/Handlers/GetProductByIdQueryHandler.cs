using Mediator.DAL;
using Mediator.MediatorPattern.Queries;
using Mediator.MediatorPattern.Results;
using MediatR;

namespace Mediator.MediatorPattern.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductUpdatedQuery, UpdateProductByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<UpdateProductByIdQueryResult> Handle(GetProductUpdatedQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new UpdateProductByIdQueryResult
            {
                ProductId = values.ProductId,
                Name = values.Name,
                Stock = values.Stock,
                Category = values.Category,
                Price = values.Price,
                StockType = values.StockType,
            };
        }
    }
}
