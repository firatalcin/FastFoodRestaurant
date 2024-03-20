using AutoMapper;
using RestaurantProject.Core.DataAccess.Dtos.DiscountDto;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.SignalRApi.Mapping
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
        }
    }
}
