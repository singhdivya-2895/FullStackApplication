using Data;
using Domain;
using MediatR;

namespace Application.Features.Details
{
    public class GetActivityByIdQueryHandler : IRequestHandler<GetActivityByIdQuery, Activity>
    {
        private readonly DataContext _context;

        public GetActivityByIdQueryHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Activity> Handle(GetActivityByIdQuery QueyID, CancellationToken cancellationToken)
        {
            return await _context.Activities.FindAsync(QueyID.Id);
        }
    }
}
