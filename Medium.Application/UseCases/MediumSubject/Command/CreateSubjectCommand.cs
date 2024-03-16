using MediatR;
using Medium.Domain.DTOs;
using Medium.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.UseCases.MediumSubject.Command
{
    public class CreateSubjectCommand : SubjectDTO ,IRequest<Subject>
    {

    }
}
