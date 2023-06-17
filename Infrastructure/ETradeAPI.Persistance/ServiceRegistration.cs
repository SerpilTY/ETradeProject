using ETradeAPI.Application.Repositories;
using ETradeAPI.Persistance.Concretes;
using ETradeAPI.Persistence;
using ETradeAPI.Persistence.Contexts;
using ETradeAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ETradeAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection service)
        {
            

            service.AddDbContext<ETradeAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString),ServiceLifetime.Singleton);
            service.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            service.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            service.AddScoped<IOrderReadRepository, OrderReadRepository>();
            service.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            service.AddScoped<IProductReadRepository, ProductReadRepository>();
            service.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            
        }
    }
}
