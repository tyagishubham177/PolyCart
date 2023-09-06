using AutoMapper;
using PolyCart.Basket.API.Entities;
using PolyCart.EventBus.Messages.Events;

namespace PolyCart.Basket.API.Mapper
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketCheckout, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
