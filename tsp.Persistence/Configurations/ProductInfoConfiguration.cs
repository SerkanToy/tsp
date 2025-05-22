using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tsp.Domain.Entities;

namespace tsp.Persistence.Configurations
{
    public class ProductInfoConfiguration : IEntityTypeConfiguration<ProductInfo>
    {
        public void Configure(EntityTypeBuilder<ProductInfo> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasMany(x => x.CategoryAndSub).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Cascade);  
            //builder.HasData(User());
        }
    }
}
