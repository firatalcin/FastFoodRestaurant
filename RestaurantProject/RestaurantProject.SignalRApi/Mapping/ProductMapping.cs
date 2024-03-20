using AutoMapper;
using RestaurantProject.Core.DataAccess.Dtos.ProductDto;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.SignalRApi.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
        }
    }
}
