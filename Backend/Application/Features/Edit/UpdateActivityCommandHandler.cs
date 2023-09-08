using Data;
using MediatR;


namespace Application.Features.Edit
{
    public class UpdateActivityCommandHandler : IRequestHandler<UpdateActivityCommandHandler>
    {
        private readonly DataContext _context;

        public UpdateActivityCommandHandler(DataContext context)
        {
            _context = context;
        }
        public Task Handle(UpdateActivityCommandHandler request, CancellationToken cancellationToken)
        {
            
        }
    }
}
