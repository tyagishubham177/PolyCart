using AutoMapper;
using PolyCart.Ordering.Application.Features.Orders.Commands.CheckoutOrder;

namespace PolyCart.Ordering.API.Mapping
{
    public class OrderingProfile : Profile
    {
        public OrderingProfile()
        {
            //CreateMap<CheckoutOrderCommand, BasketCheckoutEvent>().ReverseMap();
        }
    }
}
