using Microsoft.EntityFrameworkCore;

namespace CrecheApp.Models
{
    public class ChildContext : DbContext

    {   //DB settings for Child

        public ChildContext(DbContextOptions<ChildContext> options) : base(options)
        { }

        public DbSet<Child> Children { get; set; }
    }
}
