﻿using RestaurantProject.Business.Interfaces;
using RestaurantProject.Core.DataAccess.Dtos.ProductDto;
using RestaurantProject.DataAccess.Interfaces;
using RestaurantProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProject.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product entity)
        {
            _productDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<ResultProductWithCategoryDto> GetProductsWithCategories()
        {
            return _productDal.GetProductsWithCategories();
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
