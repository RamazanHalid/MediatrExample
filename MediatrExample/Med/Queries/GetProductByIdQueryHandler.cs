﻿using MediatR;
using MediatrExample.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Elma"
            };
            return Task.FromResult(viewModel);
            
            // Get product from repository
        }
    }
}
