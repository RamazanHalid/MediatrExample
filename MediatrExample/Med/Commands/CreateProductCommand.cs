using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrExample.Med.Commands
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }

        public class CreatepProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
        {
            public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {

                return Task.FromResult(Guid.NewGuid());
                //repository
            }
        }
    }
}
