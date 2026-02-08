using ETicaretAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistance;
public static class ServiceRegistration
{
    public static void AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ETicaretAPIDbContext>(opt =>
            opt.UseNpgsql(configuration.GetConnectionString("PostgreSql"))
        );
    }
}