﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProject.Core.DataAccess.Dtos.SocialMediaDto
{
    public class CreateSocialMediaDto
    {
        public string Title { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }
    }
}
