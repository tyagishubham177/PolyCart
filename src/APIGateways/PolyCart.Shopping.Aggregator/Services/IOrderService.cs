using PolyCart.Shopping.Aggregator.Models;

namespace PolyCart.Shopping.Aggregator.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}