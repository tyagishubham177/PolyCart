using PolyCart.Web.Entities;

namespace PolyCart.Web.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> CheckOut(Order order);
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
