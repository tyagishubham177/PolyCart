using AutoMapper;
using PolyCart.Discount.Grpc.Entities;
using PolyCart.Discount.Grpc.Protos;

namespace PolyCart.Discount.Grpc.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
