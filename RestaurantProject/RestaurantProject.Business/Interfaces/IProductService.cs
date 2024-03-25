using RestaurantProject.Core.DataAccess.Dtos.ProductDto;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.Business.Interfaces
{
    public interface IProductService : IGenericService<Product>
    {
        List<ResultProductWithCategoryDto> GetProductsWithCategories();
    }
}
