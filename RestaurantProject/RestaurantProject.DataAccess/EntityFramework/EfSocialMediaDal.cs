using RestaurantProject.DataAccess.Context;
using RestaurantProject.DataAccess.Interfaces;
using RestaurantProject.DataAccess.Repositories;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.DataAccess.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
