using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tsp.Domain.Entities;

namespace tsp.Persistence.Configurations
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Category).WithMany(x => x.SubCategory).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.NoAction); 
        }
    }
}
