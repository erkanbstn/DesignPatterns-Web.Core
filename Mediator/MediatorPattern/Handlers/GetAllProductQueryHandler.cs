using Mediator.DAL;
using Mediator.MediatorPattern.Queries;
using Mediator.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Mediator.MediatorPattern.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        async Task<List<GetAllProductQueryResult>> IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>.Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(b => new GetAllProductQueryResult
            {
                ProductId = b.ProductId,
                Category = b.Category,
                Name = b.Name,
                Price = b.Price,
                Stock = b.Stock,
                StockType = b.StockType
            }).AsNoTracking().ToListAsync();
        }
    }
}
