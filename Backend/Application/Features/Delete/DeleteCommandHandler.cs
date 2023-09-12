using AutoMapper;
using Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Delete
{
    public class DeleteCommandHandler : IRequestHandler<DeleteCommand>
    {
        private readonly DataContext _context;

        public DeleteCommandHandler(DataContext context,IMapper mapper) 
        {
            _context = context;
        }

        public IMapper Mapper { get; }

        public async Task Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
             var activity = await _context.Activities.FindAsync(request.Id);
             _context.Remove(activity);
             await _context.SaveChangesAsync();
        }
    }

}
