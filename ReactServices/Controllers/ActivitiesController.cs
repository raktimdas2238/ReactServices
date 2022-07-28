using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReactServices.Database;
using ReactServices.Database.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReactServices.Controllers
{
    public class ActivitiesController : ReactController
    {
        private readonly DatabaseContext _databaseContext;
        public ActivitiesController(DatabaseContext context)
        {
            _databaseContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _databaseContext.Activities.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivities(Guid id)
        {
            return await _databaseContext.Activities.FindAsync(id);
        }

        [HttpPost]
        public async Task<ActionResult<Activity>> PostActivity(Activity activity)
        {
            await _databaseContext.Activities.AddAsync(activity);
            await _databaseContext.SaveChangesAsync();
            return Ok();
        }
    }
}
