using tsp.Domain.Common;

namespace tsp.Domain.Entities
{
    public class SubCategory : BaseEntity
    {
        public SubCategory()
        {
            CategoryAndSub = new List<CategoryAndSub>();
        }
        public string Name { get; set; }
        public ICollection<CategoryAndSub> CategoryAndSub { get; set; }
    }
}
