using Microsoft.Extensions.DependencyInjection;

namespace MyApp.Presentation.Factories
{
    /// <summary>
    /// Provides helper methods for creating application services.
    /// </summary>
    public static class AppFactory
    {
        /// <summary>
        /// Resolves a service from the service provider with a descriptive exception if missing.
        /// </summary>
        /// <typeparam name="TService">The type of service to resolve.</typeparam>
        /// <param name="provider">The configured service provider.</param>
        /// <returns>The resolved service instance.</returns>
        public static TService Create<TService>(ServiceProvider provider) where TService : class
        {
            // Centralize service resolution so the composition root stays clean.
            return provider.GetRequiredService<TService>();
        }
    }
}
