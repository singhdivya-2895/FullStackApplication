﻿using Application.Core;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Edit
{
    public class UpdateActivityCommand :IRequest<Result<Unit>>
    {
        public Activity Activity { get; set; }
    }
}
