using Microsoft.Extensions.Logging;
using PolyCart.Ordering.Domain.Entity;

namespace PolyCart.Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetPreconfiguredOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderContext).Name);
            }
        }

        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>
            {
                new Order() {UserName = "shub", FirstName = "Shubham", LastName = "Tyagi", EmailAddress = "tyagi.shubham177@gmail.com", AddressLine = "Noida", Country = "India", TotalPrice = 350 }
            };
        }
    }
}
