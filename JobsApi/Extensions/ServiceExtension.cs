using JobsApi.Services.Contracts;
using JobsApi.Services.Implementations;

namespace JobsApi.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection RegisterService(this IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthService>();
            return services;
        }
    }
}
