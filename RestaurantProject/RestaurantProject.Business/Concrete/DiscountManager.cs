using RestaurantProject.Business.Interfaces;
using RestaurantProject.DataAccess.Interfaces;
using RestaurantProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProject.Business.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public void Add(Discount entity)
        {
            _discountDal.Add(entity);
        }

        public void Delete(Discount entity)
        {
            _discountDal.Delete(entity);
        }

        public List<Discount> GetAll()
        {
            return _discountDal.GetAll();
        }

        public Discount GetById(int id)
        {
            return _discountDal.GetById(id);
        }

        public void Update(Discount entity)
        {
            _discountDal.Update(entity);
        }
    }
}
