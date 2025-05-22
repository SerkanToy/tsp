using tsp.Domain.Common;

namespace tsp.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            SubCategory = new List<SubCategory>();
        }
        public string Name { get; set; }
        public ICollection<SubCategory> SubCategory { get; set; }
    }
}
