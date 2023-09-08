using PolyCart.Web.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PolyCart.Web.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> CheckOut(Order order);
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
