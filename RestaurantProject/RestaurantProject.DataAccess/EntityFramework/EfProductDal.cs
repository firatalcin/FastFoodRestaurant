using Microsoft.EntityFrameworkCore;
using RestaurantProject.Core.DataAccess.Dtos.ProductDto;
using RestaurantProject.DataAccess.Context;
using RestaurantProject.DataAccess.Interfaces;
using RestaurantProject.DataAccess.Repositories;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly AppDbContext _appDbContext;

        public EfProductDal(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<ResultProductWithCategoryDto> GetProductsWithCategories()
        {
            var values = _appDbContext.Products.Include(x => x.Category).Select(y => new ResultProductWithCategoryDto
            {
                CategoryName= y.Category.Name,
                Name=y.ProductName,
                Description = y.Description,
                ImageURL = y.ImageUrl,
                Price = y.Price,
                Id = y.Id,
                Status = y.Status
            }).ToList();
            return values;
        }
    }
}
