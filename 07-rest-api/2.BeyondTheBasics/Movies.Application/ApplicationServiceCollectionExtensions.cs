using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Movies.Application.Database;
using Movies.Application.Repositories;
using Movies.Application.Services;

namespace Movies.Application;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddSingleton<IMovieRepository, MovieRepository>();
        services.AddSingleton<IMovieService, MovieService>();
        // Procura todos validadores no assembly que contém IApplicationMarker
        services.AddValidatorsFromAssemblyContaining<IApplicationMarker>(ServiceLifetime.Singleton);
        return services;
    }

    public static IServiceCollection AddDatabase(this IServiceCollection services,
        string connectionString)
    {
        // Usa lambda para garantir que connectionString seja resolvido no momento da injeção
        services.AddSingleton<IDbConnectionFactory>(_ =>
            new NpgsqlDbConnectionFactory(connectionString));

        services.AddSingleton<DbInitializer>();

        return services;
    }
}
