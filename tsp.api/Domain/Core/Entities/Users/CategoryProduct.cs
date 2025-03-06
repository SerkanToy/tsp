namespace tsp.api.Domain.Core.Entities.Users
{
    public class CategoryProduct
    {
        public Product Product { get; set; }
        public Guid ProductId { get; set; }
        public Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
