﻿using RestaurantProject.Core.Entities;

namespace RestaurantProject.Entities.Concrete
{
    public class SocialMedia : BaseEntity
    {
        public string Title { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }

    }
}
