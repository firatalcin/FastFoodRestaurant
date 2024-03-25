using RestaurantProject.Core.DataAccess.Dtos.ProductDto;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.DataAccess.Interfaces
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<ResultProductWithCategoryDto> GetProductsWithCategories();
    }
}
