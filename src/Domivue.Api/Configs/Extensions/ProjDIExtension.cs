public static class ProjDIExtension
{
    public static IServiceCollection AddProjServices(this IServiceCollection services)
    {
        services.AddScoped<IListingRepository, ListingRepository>();
        return services;
    }
}