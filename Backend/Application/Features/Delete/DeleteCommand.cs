using Application.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Delete
{
    public class DeleteCommand : IRequest<Result<Unit>>
    { 
        public Guid Id { get; set; }
    }
}
