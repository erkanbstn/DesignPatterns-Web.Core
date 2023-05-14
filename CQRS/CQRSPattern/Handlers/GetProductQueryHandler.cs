using CQRS.CQRSPattern.Results;
using CQRS.DAL;
using System.Collections.Generic;
using System.Linq;

namespace CQRS.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductId = x.ProductId,
                ProductName = x.Name,
                Stock = x.Stock,
                Price = x.Price,
            }).ToList();
            return values;
            
        }
    }
}
