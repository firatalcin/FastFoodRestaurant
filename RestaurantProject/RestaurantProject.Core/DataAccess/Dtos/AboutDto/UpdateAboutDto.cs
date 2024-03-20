using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantProject.Core.DataAccess.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ModifyDate { get; set; } = DateTime.Now;
    }
}
