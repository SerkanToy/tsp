using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using tsp.Domain.Entities;

namespace tsp.Persistence.Configurations
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasOne(x => x.Category).WithMany(x => x.CategoryAndSub).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.NoAction);  
            //builder.HasOne(x => x.SubCategory).WithMany(x => x.CategoryAndSub).HasForeignKey(x => x.SubCategoryId).OnDelete(DeleteBehavior.NoAction);  
            //builder.HasData(User());
        }
    }
}
