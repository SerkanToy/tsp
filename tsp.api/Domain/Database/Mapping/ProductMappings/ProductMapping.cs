using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tsp.api.Domain.Core.Entities.Users;

namespace tsp.api.Domain.Database.Mapping.ProductMappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(500).IsRequired();
            builder.HasMany(x => x.CategoryProducts).WithOne(x => x.Product).HasForeignKey(x => x.CategoryId);
            builder.HasData(_product());
        }

        private IList<Product> _product()
        {
            return new List<Product>
            {
                new Product { Id = Guid.Parse("F4D3D3A3-3D3D-4D3D-3D3D-3D3D3D3D3D3D"), Name = "Product 1" },
                new Product { Id = Guid.Parse("5AA8432B-992E-43CD-BC4C-DA039E117217"), Name = "Product 2" },
                new Product { Id = Guid.Parse("0C4F2938-A450-4038-9C12-2270B30C1FD9"), Name = "Product 3" },
                new Product { Id = Guid.Parse("2FD8ACBE-8A33-43BC-9A8F-512162CD1993"), Name = "Product 4" }
            };
        }
    }
}
