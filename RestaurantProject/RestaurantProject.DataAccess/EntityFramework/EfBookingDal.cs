using RestaurantProject.DataAccess.Context;
using RestaurantProject.DataAccess.Interfaces;
using RestaurantProject.DataAccess.Repositories;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.DataAccess.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
