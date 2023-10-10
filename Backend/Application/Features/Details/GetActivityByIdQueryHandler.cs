using Application.Core;
using Data;
using Domain;
using MediatR;

namespace Application.Features.Details
{
    public class GetActivityByIdQueryHandler : IRequestHandler<GetActivityByIdQuery, Result<Activity>>
    {
        private readonly DataContext _context;

        public GetActivityByIdQueryHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<Result<Activity>> Handle(GetActivityByIdQuery QueyID, CancellationToken cancellationToken)
        {
            if (QueyID.Id.Equals(Guid.Parse("6B29FC40-CA47-1067-B31D-00DD010662DA"))) { 
                return Result<Activity>.Failure("Mera error"); 
            }
            var activity = await _context.Activities.FindAsync(QueyID.Id);
            if (activity == null) { return Result<Activity>.Failure("Activity not found"); }
            return Result<Activity>.Success(activity);
        }
    }
}
