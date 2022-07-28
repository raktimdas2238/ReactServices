using Microsoft.EntityFrameworkCore;
using ReactServices.Database.Entities;

namespace ReactServices.Database
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Activity> Activities{ get; set; }
    }
}
