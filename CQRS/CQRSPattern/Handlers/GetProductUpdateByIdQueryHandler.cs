using CQRS.CQRSPattern.Queries;
using CQRS.CQRSPattern.Results;
using CQRS.DAL;

namespace CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery getProductUpdateByIdQuery)
        {
            var values = _context.Products.Find(getProductUpdateByIdQuery.ProductId);
            return new GetProductUpdateQueryResult
            {
                Description = values.Description,
                ProductId = values.ProductId,
                Price = values.Price,
                Stock = values.Stock,
                Name = values.Name,
            };
        }
    }
}
