using CQRS.CQRSPattern.Queries;
using CQRS.CQRSPattern.Results;
using CQRS.DAL;

namespace CQRS.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIdQueryResult Handle(GetProductByIdQuery getProductByIdQuery)
        {
            var values = _context.Set<Product>().Find(getProductByIdQuery.Id);
            return new GetProductByIdQueryResult
            {
                Name=values.Name,
                Price=values.Price,
                Stock=values.Stock, 
                ProductId=values.ProductId
            };
        }
    }
}
