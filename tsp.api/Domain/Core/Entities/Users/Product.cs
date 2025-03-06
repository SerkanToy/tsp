namespace tsp.api.Domain.Core.Entities.Users
{
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryProduct> CategoryProducts { get; set; }
    }
}
