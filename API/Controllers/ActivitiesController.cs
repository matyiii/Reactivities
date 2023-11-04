using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
	public class ActivitiesController : BaseApiController
	{
		private readonly DataContext context;
		public ActivitiesController(DataContext context)
		{
			this.context = context;
		}

		[HttpGet] //api/activites
		public async Task<ActionResult<List<Activity>>> GetActivities()
		{
			return await context.Activities.ToListAsync();
		}

		[HttpGet("{id}")] //api/activites/id
		public async Task<ActionResult<Activity>> GetActivityById(Guid id)
		{
			return await context.Activities.FirstOrDefaultAsync(x => x.Id == id);
		}
	}
}