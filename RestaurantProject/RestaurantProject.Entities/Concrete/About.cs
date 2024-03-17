﻿using RestaurantProject.Core.Entities;

namespace RestaurantProject.Entities.Concrete
{
    public class About : BaseEntity
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
