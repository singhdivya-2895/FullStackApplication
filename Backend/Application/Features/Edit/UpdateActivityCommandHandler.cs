using Application.Core;
using AutoMapper;
using Data;
using MediatR;


namespace Application.Features.Edit
{
    public class UpdateActivityCommandHandler : IRequestHandler<UpdateActivityCommand, Result<Unit>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateActivityCommandHandler(DataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Result<Unit>> Handle(UpdateActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(request.Activity.Id);

            if (activity == null) return null; 
            _mapper.Map(request.Activity, activity);
            var intResult = await _context.SaveChangesAsync();
            var result = intResult > 0 ;
            if(!result)
            {
                return Result<Unit>.Failure("Failed to Update Activity");
            }
            return Result<Unit>.Success(Unit.Value);
        }
    }
}
