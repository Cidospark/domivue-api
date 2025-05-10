using Domivue.Core.Domains;
using Domivue.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Domivue.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string conStr)
        {
            // Register infrastructure services here

            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseNpgsql(conStr).UseSnakeCaseNamingConvention();
            });

            // services.AddIdentity<User, IdentityRole>()
            // .AddEntityFrameworkStores<ApplicationDbContext>()
            // .AddDefaultTokenProviders();

            return services;
        }
    }
}