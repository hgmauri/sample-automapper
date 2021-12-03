using Microsoft.Extensions.DependencyInjection;

namespace Sample.Automapper.WebApi.Core.Extensions;

public static class AutomapperExtension
{
    public static IServiceCollection AddAutoMapperApi(this IServiceCollection services, Type assemblyContainingMappers)
    {
        services.AddAutoMapper(assemblyContainingMappers);

        return services;
    }
}
