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
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.MessageRoom).WithMany(x => x.Messages).HasForeignKey(x => x.MessageRoomId).OnDelete(DeleteBehavior.NoAction);  
            builder.HasOne(x => x.User).WithMany(x => x.Message).HasForeignKey(x => x.MessageRoomId).OnDelete(DeleteBehavior.NoAction);  
        }
    }
}
