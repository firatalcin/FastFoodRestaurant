﻿using RestaurantProject.DataAccess.Context;
using RestaurantProject.DataAccess.Interfaces;
using RestaurantProject.DataAccess.Repositories;
using RestaurantProject.Entities.Concrete;

namespace RestaurantProject.DataAccess.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public EfDiscountDal(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
