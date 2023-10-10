using Application.Core;
using Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Create
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand, Result<Unit>>
    {
        private readonly DataContext _context;

        public CreateActivityCommandHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Result<Unit>> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            _context.Activities.Add(request.Activity);
            var result =  await _context.SaveChangesAsync() > 0;
            if (!result) return Result<Unit>.Failure("Failed to create activity");
            return Result<Unit>.Success(Unit.Value);
        }
    }
}
