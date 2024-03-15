using RestaurantProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProject.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
