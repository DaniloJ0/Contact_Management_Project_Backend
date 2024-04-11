using ContactManagement.Domain.Contacts;
using ContactManagement.Domain.Users;
using ContactManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ContactManagement.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection") ??
                    throw new InvalidOperationException("Connection string not found")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();

            return services;
        }
    }
}
