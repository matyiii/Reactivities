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

		[HttpGet] //api/activites
		public async Task<ActionResult<List<Activity>>> GetActivities()
		{
			return await Mediator.Send(new List.Query());
		}

		[HttpGet("{id}")] //api/activites/id
		public async Task<ActionResult<Activity>> GetActivityById(Guid id)
		{
			return await Mediator.Send(new Details.Query { Id = id });
		}

		[HttpPost]
		public async Task<IActionResult> CreateActivity([FromBody]Activity activity)
		{
			await Mediator.Send(new Create.Command { Activity = activity });

			return Ok();
		}
	}
}