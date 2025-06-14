using ShopEasy.API.Helpers;
using ShopEasy.API.Services;

namespace ShopEasy.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAppService(this IServiceCollection services)
        {
            services.AddScoped<ICustomLoggerProvider, CustomLoggerProvider>();
            services.AddScoped<IEmailNotifiactionService, EmailNotificationService>();
            services.AddScoped<JwtTokenGenerator>();
            return services;
        }
    }
}
