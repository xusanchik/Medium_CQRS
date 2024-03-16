using AutoMapper;
using MediatR;
using Medium.Application.Absatractions;
using Medium.Application.UseCases.MediumUser.Commands;
using Medium.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.UseCases.MediumSubject.Handler
{
    public class CreateSubjectHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;
        public CreateSubjectHandler(IMapper mapper, IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext= applicationDbContext;
            _mapper= mapper;
        }

        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<Subject>(request);

            if (result is not null)
            {
                _applicationDbContext.Subjects.Add(result);
                await _applicationDbContext.SaveChangesAsync();
                return result;

            }
        }
    }
}
