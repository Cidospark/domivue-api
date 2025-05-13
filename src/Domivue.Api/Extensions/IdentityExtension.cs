using Domivue.Api.Data;
using Domivue.Api.Modules.Users.Models.Entities;
using Microsoft.AspNetCore.Identity;

public static class IdentityExtension
{
    public static IServiceCollection AddIdentityService(this IServiceCollection services)
    {
       
        services.AddIdentity<User, IdentityRole>(
                        options => {
                            options.SignIn.RequireConfirmedAccount = true;
                        })
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();
        return services;
    }
}
