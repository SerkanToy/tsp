using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tsp.Domain.Entities;

namespace tsp.Persistence.Configurations
{
    public class UnitConfiguration : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasOne(x => x.Category).WithMany(x => x.CategoryAndSub).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.NoAction);  
            //builder.HasOne(x => x.SubCategory).WithMany(x => x.CategoryAndSub).HasForeignKey(x => x.SubCategoryId).OnDelete(DeleteBehavior.NoAction);  
            //builder.HasData(User());
        }
    }
}
