using Microsoft.EntityFrameworkCore;
using Reddit.Models;

namespace Reddit
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
            base(options) 
        {
        }
    }
}
