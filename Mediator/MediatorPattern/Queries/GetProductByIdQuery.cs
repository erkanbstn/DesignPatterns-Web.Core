using Mediator.MediatorPattern.Results;
using MediatR;

namespace Mediator.MediatorPattern.Queries
{
    public class GetProductUpdatedQuery : IRequest<UpdateProductByIdQueryResult>
    {
        public int Id { get; set; }

        public GetProductUpdatedQuery(int id)
        {
            Id = id;
        }
    }
}
