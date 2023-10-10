using Application.Core;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Details
{
    public class GetActivityByIdQuery: IRequest<Result<Activity>>
    {
        public Guid Id { get; set; }
    }
}
