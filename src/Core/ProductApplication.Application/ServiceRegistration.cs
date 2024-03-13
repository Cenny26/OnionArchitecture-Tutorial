using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ProductApplication.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddAutoMapper(assembly);
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(assembly);
            });
        }
    }
}
