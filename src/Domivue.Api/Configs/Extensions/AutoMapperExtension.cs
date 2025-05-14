public static class AutoMapperExtension
{
    public static IServiceCollection AddAutoMapperService(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(Program));
        return services;
    }
}