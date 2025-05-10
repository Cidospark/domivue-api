using Domivue.Core.Domains;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domivue.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Add DbSet properties for your entities here
        // Example:
        // public DbSet<MyEntity> MyEntities { get; set; }
    }
}