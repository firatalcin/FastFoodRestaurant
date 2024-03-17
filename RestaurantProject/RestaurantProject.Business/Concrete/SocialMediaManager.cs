﻿using RestaurantProject.Business.Interfaces;
using RestaurantProject.DataAccess.Interfaces;
using RestaurantProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProject.Business.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;
        public void Add(SocialMedia entity)
        {
            _socialMediaDal.Add(entity);
        }

        public void Delete(SocialMedia entity)
        {
            _socialMediaDal.Delete(entity);
        }

        public List<SocialMedia> GetAll()
        {
            return _socialMediaDal.GetAll();
        }

        public SocialMedia GetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public void Update(SocialMedia entity)
        {
            _socialMediaDal.Update(entity); 
        }
    }
}
