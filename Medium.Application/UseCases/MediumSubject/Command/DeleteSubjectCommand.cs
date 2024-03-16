using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.UseCases.MediumSubject.Command
{
    public class DeleteSubjectCommand : IRequest
    {
        public int Id { get; set; }
    }
}
