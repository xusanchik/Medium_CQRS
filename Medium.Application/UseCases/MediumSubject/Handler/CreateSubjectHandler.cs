using MediatR;
using Medium.Application.UseCases.MediumUser.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.UseCases.MediumSubject.Handler
{
    public class CreateSubjectHandler : IRequestHandler<CreateUserCommand>
    {
        public Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

        }
    }
}
