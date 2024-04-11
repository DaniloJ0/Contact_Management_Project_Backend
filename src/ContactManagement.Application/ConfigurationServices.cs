using ContactManagement.Application.UserService.Commands.CreateUser;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ContactManagement.Application
{
    public  static class ConfigurationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblyContaining<CreateUserCommandValidator>();
            services.AddMediatR(ctg =>
            ctg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}
