using Microsoft.EntityFrameworkCore;

namespace TODO.WebApi.Models
{
    public class TODOAppDbContext : DbContext
    {
        public TODOAppDbContext(DbContextOptions<TODOAppDbContext> options) : base(options) {}

        public DbSet<Users> Users { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("TODOAppUsers");
            modelBuilder.Entity<TodoItem>().ToTable("TodoItems");
        }*/

    }
}
