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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature entity)
        {
            _featureDal.Add(entity);
        }

        public void Delete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public List<Feature> GetAll()
        {
            return _featureDal.GetAll();
        }

        public Feature GetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public void Update(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
