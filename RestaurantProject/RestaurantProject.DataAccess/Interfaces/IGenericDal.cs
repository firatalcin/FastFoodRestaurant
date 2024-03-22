﻿namespace RestaurantProject.DataAccess.Interfaces
{
    public interface IGenericDal<T> where T : class, new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        List<T> GetAll();   
    }
}
