using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tsp.Domain.Enum;

namespace tsp.Domain.Entities
{
    public class Request
    {
        public Status Status { get; set; } = Status.Accepted;
        [ForeignKey(nameof(SenderUser))]
        public Guid SenderUserId { get; set; }
        public User SenderUser { get; set; }

        [ForeignKey(nameof(ReceiverUser))]
        public Guid ReceiverUserId { get; set; }
        public User ReceiverUser { get; set; }
    }
}
