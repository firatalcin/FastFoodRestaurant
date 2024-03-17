﻿using RestaurantProject.Core.Entities;

namespace RestaurantProject.Entities.Concrete
{
    public class Discount : BaseEntity
    {
        public string Title { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
