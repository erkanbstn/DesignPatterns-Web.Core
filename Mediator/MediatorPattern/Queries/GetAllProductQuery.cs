using Mediator.MediatorPattern.Results;
using MediatR;

namespace Mediator.MediatorPattern.Queries
{
    public class GetAllProductQuery : IRequest<List<GetAllProductQueryResult>>
    {
    }
}
