using Application.Activities;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
	public class ActivitiesController : BaseApiController
	{
		private readonly IMediator mediator;
		public ActivitiesController(IMediator mediator)
		{
			this.mediator = mediator;
		}

		[HttpGet] //api/activites
		public async Task<ActionResult<List<Activity>>> GetActivities()
		{
			return await mediator.Send(new List.Query());
		}

		[HttpGet("{id}")] //api/activites/id
		public async Task<ActionResult<Activity>> GetActivityById(Guid id)
		{
			return null;
		}
	}
}