using SellerSolution.ApplicationService.AutoMapperConfigurations;
using SellerSolution.ApplicationService.Interfaces;
using SellerSolution.ApplicationService.Services;

namespace SellerSolution.API.Ioc
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            AutoMapperConfig.Inicialize();

            services.AddScoped<IConsumerService, ConsumerService>();
            services.AddScoped<IContextService, ContextService>();
        }
    }
}
