using tsp.Domain.Common;

namespace tsp.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            CategoryAndSub = new List<CategoryAndSub>();
        }
        public string Name { get; set; }
        public ICollection<CategoryAndSub> CategoryAndSub { get; set; }
    }
}
