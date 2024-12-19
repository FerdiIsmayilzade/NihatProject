using Microsoft.Extensions.DependencyInjection;
using Service.Services;
using Service.Services.Interfaces;
using System.Reflection;

namespace Repository
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServicelayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<IDiscountService, DiscountService>();
            return services;
        }
        
    }
}
