using AutoMapper;
using Discount.Grpc.Protos;
using PolyCart.Discount.Grpc.Entities;

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
