using Microsoft.EntityFrameworkCore;

namespace poopants.Data
{
    public class movieDBContext : DbContext
    {
        //creating the movie context
        public movieDBContext(DbContextOptions<movieDBContext> options) : base(options) { }

        public DbSet<Movies> Movies { get; set; }
    }
}
