using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tsp.api.Domain.Core.Entities.Users;

namespace tsp.api.Domain.Database.Mapping.ProductMappings
{
    public class CategoryProductMapping : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.HasKey(x => new { x.CategoryId, x.ProductId });
            builder.HasOne(x => x.Category).WithMany(x => x.CategoryProducts).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Product).WithMany(x => x.CategoryProducts).HasForeignKey(x => x.ProductId);
            builder.HasData(_categoryProducts());
        }

        private IList<CategoryProduct> _categoryProducts()
        {
            return new List<CategoryProduct> { 
                new CategoryProduct { CategoryId = Guid.Parse("F4D3D3A3-3D3D-4D3D-3D3D-3D3D3D3D3D3D"), ProductId = Guid.Parse("F4D3D3A3-3D3D-4D3D-3D3D-3D3D3D3D3D3D") },
                new CategoryProduct { CategoryId = Guid.Parse("5AA8432B-992E-43CD-BC4C-DA039E117217"), ProductId = Guid.Parse("5AA8432B-992E-43CD-BC4C-DA039E117217") },
                new CategoryProduct { CategoryId = Guid.Parse("F4D3D3A3-3D3D-4D3D-3D3D-3D3D3D3D3D3D"), ProductId = Guid.Parse("0C4F2938-A450-4038-9C12-2270B30C1FD9") },
                new CategoryProduct { CategoryId = Guid.Parse("5AA8432B-992E-43CD-BC4C-DA039E117217"), ProductId = Guid.Parse("2FD8ACBE-8A33-43BC-9A8F-512162CD1993") }
            };
        }
    }
}
