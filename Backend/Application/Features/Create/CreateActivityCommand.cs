using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Create
{
    public class CreateActivityCommand :IRequest
    {
        public Activity Activity { get; set; }
    }
}
