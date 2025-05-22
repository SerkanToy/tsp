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
    public class FormConfiguration : IEntityTypeConfiguration<Form>
    {
        public void Configure(EntityTypeBuilder<Form> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasMany(x => x.).WithMany(x => x.CategoryAndSub).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.NoAction);  
        }
    }
}
