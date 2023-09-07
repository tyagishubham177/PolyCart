using PolyCart.Shopping.Aggregator.Models;

namespace PolyCart.Shopping.Aggregator.Services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}