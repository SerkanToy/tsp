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
    public class MessageRoomConfiguration : IEntityTypeConfiguration<MessageRoom>
    {
        public void Configure(EntityTypeBuilder<MessageRoom> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.SenderUser).WithMany(x => x.MessageRoom).HasForeignKey(x => x.SenderUserId).OnDelete(DeleteBehavior.Cascade);  
            builder.HasOne(x => x.ReceiverUser).WithMany(x => x.MessageRoom).HasForeignKey(x => x.ReceiverUserId).OnDelete(DeleteBehavior.Cascade);  
        }
    }
}
