using Application.Features.GetAll;
using Application.Features.Details;
using Data;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Application.Features.Create;
using Application.Features.Edit;
using Application.Features.Delete;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        public ActivitiesController(IMediator mediator) : base(mediator)
        {

        }
        [HttpGet]//api/activities
        public async Task<IActionResult> GetActivities()
        {
            return HandleResult(await _mediator.Send(new GetAllActivitiesQuery()));
        }
        
        [HttpGet("{id}")]//api/activities//fvjhghgd
        public async Task<IActionResult> GetActivitiesById(Guid id)
        {
           return HandleResult(await _mediator.Send(new GetActivityByIdQuery { Id = id }));
        }
        [HttpPost]
        public async Task<IActionResult> CreateActivities (Activity activity)
        {
            return HandleResult(await _mediator.Send(new CreateActivityCommand { Activity = activity }));
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateActivities(Guid id, Activity activity)
        {
            activity.Id = id;
            return HandleResult(await _mediator.Send(new UpdateActivityCommand { Activity = activity })); 
        }
        [HttpDelete("{id}")]
         
        public async Task<ActionResult> DeleteActivities(Guid id)
        {
            return HandleResult(await _mediator.Send(new DeleteCommand { Id = id }));
        }
    }
}
