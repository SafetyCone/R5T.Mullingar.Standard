using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Mullingar.Default;


namespace R5T.Mullingar.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddHelloWorldMessageProvider(this IServiceCollection services)
        {
            services.AddSingleton<IHelloWorldMessageProvider, HelloWorldMessageProvider>();

            return services;
        }
    }
}
