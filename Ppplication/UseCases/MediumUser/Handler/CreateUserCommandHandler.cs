using Application.Abstractions;
using Application.UseCases.MediumUser.Comands;
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
        public CreateUserCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Task<Unit> Handle(CreateUserComand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
