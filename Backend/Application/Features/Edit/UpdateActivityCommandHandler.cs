using AutoMapper;
using Data;
using MediatR;


namespace Application.Features.Edit
{
    public class UpdateActivityCommandHandler : IRequestHandler<UpdateActivityCommand>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateActivityCommandHandler(DataContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task Handle(UpdateActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(request.Activity.Id);

            _mapper.Map(request.Activity, activity);
           
            await _context.SaveChangesAsync();
        }
    }
}
