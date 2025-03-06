using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tsp.api.Domain.Core.Entities.Users;

namespace tsp.api.Domain.Database.Mapping.CategoryMappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(500).IsRequired();
            builder.HasMany(x => x.CategoryProducts).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
            builder.HasData(_category());
        }

        private IList<Category> _category() 
        { 

            return new List<Category> { 
                new Category { Id = Guid.Parse("F4D3D3A3-3D3D-4D3D-3D3D-3D3D3D3D3D3D"), Name = "Category 1" },
                new Category { Id = Guid.Parse("5AA8432B-992E-43CD-BC4C-DA039E117217"), Name = "Category 2" }
            }; 
        }
    }
}
