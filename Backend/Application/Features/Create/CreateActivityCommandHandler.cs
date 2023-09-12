using Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Create
{
    public class CreateActivityCommandHandler : IRequestHandler<CreateActivityCommand>
    {
        private readonly DataContext _context;

        public CreateActivityCommandHandler(DataContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            _context.Activities.Add(request.Activity);
            await _context.SaveChangesAsync();
           
        }

    }
}
