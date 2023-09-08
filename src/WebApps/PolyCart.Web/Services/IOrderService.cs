using PolyCart.Web.Models;

namespace PolyCart.Web.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderResponseModel>> GetOrdersByUserName(string userName);
    }
}