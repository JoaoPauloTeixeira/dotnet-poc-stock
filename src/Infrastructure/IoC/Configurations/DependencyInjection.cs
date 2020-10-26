using System;
using Microsoft.Extensions.DependencyInjection;

namespace src.Infrastructure.IoC.Configurations
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjector.RegisterServices(services);
        }
    }
}