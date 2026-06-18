using Microsoft.EntityFrameworkCore;
using t2.Server.Models;

namespace t2.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
    }
}