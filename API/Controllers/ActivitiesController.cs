using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{


    public class ActivitiesController : BaseAPIController
    {
        private readonly DataContext context;

        public ActivitiesController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet] //api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            
            return await this.context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] //api/activities/asdfas
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await this.context.Activities.FindAsync(id);
        }

    }
}