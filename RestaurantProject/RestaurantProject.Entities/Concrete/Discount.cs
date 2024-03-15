using RestaurantProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
