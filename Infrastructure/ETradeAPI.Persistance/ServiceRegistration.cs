using ETradeAPI.Application.Abstraction;
using ETradeAPI.Persistance.Concretes;
using ETradeAPI.Persistence;
using ETradeAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace ETradeAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection service)
        {
            

            service.AddDbContext<ETradeAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
