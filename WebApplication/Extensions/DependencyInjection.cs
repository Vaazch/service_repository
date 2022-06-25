namespace WebApi.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IPersonSevice, PersonService>();

        return services;
    }
}