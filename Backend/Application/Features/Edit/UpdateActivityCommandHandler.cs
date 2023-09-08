using Data;
using MediatR;


namespace Application.Features.Edit
{
    public class UpdateActivityCommandHandler : IRequestHandler<UpdateActivityCommand>
    {
        private readonly DataContext _context;

        public UpdateActivityCommandHandler(DataContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(request.Activity.Id);
           
            activity.Title = request.Activity.Title ?? activity.Title;
           
            await _context.SaveChangesAsync();
        }
    }
}
