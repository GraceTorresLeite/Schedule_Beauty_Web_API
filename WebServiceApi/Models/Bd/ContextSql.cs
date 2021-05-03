using Microsoft.EntityFrameworkCore;

namespace WebServiceApi.Models.Bd
{
    public class ContextSql : DbContext
    {
        public ContextSql()
        {

        }
        public ContextSql(DbContextOptions<ContextSql> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ScheduleForm> SchedulesForms { get; set; }
    }
}
