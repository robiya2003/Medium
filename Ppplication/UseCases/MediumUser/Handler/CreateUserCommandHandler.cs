using Application.Abstractions;
using Application.UseCases.MediumUser.Comands;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.MediumUser.Handler
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserComand>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;
        public CreateUserCommandHandler(IApplicationDbContext applicationDbContext,
            IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper=mapper;
        }
        public Task<Unit> Handle(CreateUserComand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
