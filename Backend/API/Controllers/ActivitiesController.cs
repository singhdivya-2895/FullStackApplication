﻿using Application.Features.GetAll;
using Application.Features.Details;
using Data;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Application.Features.Create;
using Application.Features.Edit;
using Application.Features.Delete;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        public ActivitiesController(IMediator mediator) : base(mediator)
        {

        }
        [HttpGet]//api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _mediator.Send(new GetAllActivitiesQuery());
        }

        [HttpGet("{id}")]//api/activities//fvjhghgd
        public async Task<ActionResult<Activity>> GetActivitiesById(Guid id)
        {
            return await _mediator.Send(new GetActivityByIdQuery { Id = id });
        }
        [HttpPost]
        public async Task<ActionResult> CreateActivities (Activity activity)
        {
            await _mediator.Send(new CreateActivityCommand { Activity = activity });
            return Accepted();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateActivities(Guid id, Activity activity)
        {
            activity.Id = id;
            await _mediator.Send(new UpdateActivityCommand { Activity = activity });
            return Accepted(); 
        }
        [HttpDelete("{id}")]
         
        public async Task<ActionResult> DeleteActivities(Guid id)
        {
            await _mediator.Send(new DeleteCommand { Id = id });
            return Ok();
        }
    }
}
