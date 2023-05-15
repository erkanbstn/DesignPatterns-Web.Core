using Mediator.MediatorPattern.Results;
using MediatR;

namespace Mediator.MediatorPattern.Queries
{
    public class Test : IRequest<UpdateProductByIdQueryResult>
    {
        public int Id { get; set; }

        public Test(int id)
        {
            Id = id;
        }
    }
}
