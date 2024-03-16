using RestaurantProject.DataAccess.Context;
using RestaurantProject.DataAccess.Interfaces;
using RestaurantProject.DataAccess.Repositories;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
