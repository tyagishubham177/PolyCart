using Microsoft.EntityFrameworkCore;
using PolyCart.Ordering.Application.Contracts.Persistence;
using PolyCart.Ordering.Domain.Entity;
using PolyCart.Ordering.Infrastructure.Persistence;

namespace PolyCart.Ordering.Infrastructure.Repository
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(OrderContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Order>> GetOrdersByUserName(string userName)
        {
            var orderList = await _dbContext.Orders
                                    .Where(o => o.UserName == userName)
                                    .ToListAsync();
            return orderList;
        }
    }
}
