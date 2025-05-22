using System.ComponentModel.DataAnnotations.Schema;
using tsp.Domain.Common;

namespace tsp.Domain.Entities
{
    public class SubCategory : BaseEntity
    {
        public SubCategory()
        {
        }
        public string Name { get; set; }
        [ForeignKey(nameof(Category))]
        public string CategoryId { get; set; }        
        public Category Category { get; set; }
    }
}
