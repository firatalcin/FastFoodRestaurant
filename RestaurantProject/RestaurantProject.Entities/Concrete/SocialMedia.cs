﻿using RestaurantProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProject.Entities.Concrete
{
    public class SocialMedia : BaseEntity
    {
        public string Title { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }

    }
}
