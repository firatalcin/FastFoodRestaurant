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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial entity)
        {
            _testimonialDal.Add(entity);    
        }

        public void Delete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
        }

        public List<Testimonial> GetAll()
        {
            return _testimonialDal.GetAll();    
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public void Update(Testimonial entity)
        {
            _testimonialDal.Update(entity); 
        }
    }
}
