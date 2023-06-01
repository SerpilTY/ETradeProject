using ETradeAPI.Application.Abstraction;
using ETradeAPI.Persistance.Concretes;
using Microsoft.Extensions.DependencyInjection;


namespace ETradeAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection service)
        {
            service.AddSingleton<IProductService, ProductService>();
        }
    }
}
