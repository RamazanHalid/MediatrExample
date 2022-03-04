using MediatR;
using MediatrExample.Entities;
using System;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
            
    }
}
