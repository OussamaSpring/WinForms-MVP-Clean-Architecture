using Microsoft.Extensions.DependencyInjection;
using MyApp.Data.Repositories;
using MyApp.Presentation.Presenters;
using MyApp.Presentation.Views.Forms;
using MyApp.Presentation.Views.Interfaces;
using MyApp.UseCases.UseCase;
using MyApp.UseCases.UseCase.Interfaces;

internal static class ServiceConfigurator
{
    /// <summary>
    /// Configures the application's services and dependencies.
    /// </summary>
    /// <returns>A configured ServiceProvider instance.</returns>
    public static ServiceProvider Configure()
    {
        var services = new ServiceCollection();

        RegisterRepositories(services);
        RegisterServices(services);
        RegisterPresentation(services);

        return services.BuildServiceProvider();
    }


    /// <summary>
    /// Registers the application's repositories.
    /// </summary>
    /// <param name="services">The service collection to register repositories with.</param>
    private static void RegisterRepositories(IServiceCollection services)
    {
        // Register the data access implementations used by the use cases.
        services.AddSingleton<MyApp.Core.Interfaces.Repositories.ISampleItemRepository, InMemorySampleItemRepository>();
    }

    /// <summary>
    /// Registers the application's services.
    /// </summary>
    /// <param name="services">The service collection to register services with.</param>
    private static void RegisterServices(IServiceCollection services)
    {
        // Register application use cases.
        services.AddTransient<IGetSampleItemsUseCase, GetSampleItemsUseCase>();
    }

    /// <summary>
    /// Registers the application's presentation layer components.
    /// </summary>
    /// <param name="services">The service collection to register presentation components with.</param>
    private static void RegisterPresentation(IServiceCollection services)
    {
        // Register views and presenters for the MVP layer.
        services.AddSingleton<SampleItemForm>();
        services.AddSingleton<ISampleItemView>(provider => provider.GetRequiredService<SampleItemForm>());
        services.AddSingleton<SampleItemPresenter>();
    }
}