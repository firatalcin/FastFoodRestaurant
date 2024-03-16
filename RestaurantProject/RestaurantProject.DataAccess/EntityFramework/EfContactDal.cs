using RestaurantProject.DataAccess.Context;
using RestaurantProject.DataAccess.Interfaces;
using RestaurantProject.DataAccess.Repositories;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.DataAccess.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
