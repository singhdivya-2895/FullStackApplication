using Application.Core;
using Data;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.GetAll
{
    public class GetAllActivitiesQueryHandler : IRequestHandler<GetAllActivitiesQuery, Result<List<Activity>>>
    {
        private readonly DataContext _context;

        public GetAllActivitiesQueryHandler(DataContext context)
        {
            _context = context;
        }
        public async Task<Result<List<Activity>>> Handle(GetAllActivitiesQuery request, CancellationToken cancellationToken)
        {
            return Result<List<Activity>>.Success(await _context.Activities.ToListAsync());
        }
    }
}
