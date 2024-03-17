using RestaurantProject.Core.Entities;

namespace RestaurantProject.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
