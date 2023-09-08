using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PolyCart.Ordering.Application.Contracts.Infrastructure;
using PolyCart.Ordering.Application.Contracts.Persistence;
using PolyCart.Ordering.Application.Models;
using PolyCart.Ordering.Infrastructure.Mail;
using PolyCart.Ordering.Infrastructure.Persistence;
using PolyCart.Ordering.Infrastructure.Repository;

namespace PolyCart.Ordering.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OrderContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("OrderingConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
    }
}
