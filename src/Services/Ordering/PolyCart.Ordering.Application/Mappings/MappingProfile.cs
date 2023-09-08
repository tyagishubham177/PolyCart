using AutoMapper;
using PolyCart.Ordering.Application.Features.Orders.Commands.CheckoutOrder;
using PolyCart.Ordering.Application.Features.Orders.Commands.UpdateOrder;
using PolyCart.Ordering.Application.Queries;
using PolyCart.Ordering.Domain.Entity;

namespace PolyCart.Ordering.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}
