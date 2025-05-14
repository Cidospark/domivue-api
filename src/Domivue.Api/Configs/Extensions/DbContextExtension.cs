using Domivue.Api.Configs.Data;
using Microsoft.EntityFrameworkCore;

public static class DbContextExtension
{
    public static IServiceCollection AddDbContextService(this IServiceCollection services, string conStr)
    {
       services.AddDbContext<ApplicationDbContext>(options => {
            options.UseNpgsql(conStr);
        });

        return services;
    }
}
