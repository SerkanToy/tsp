using System.ComponentModel.DataAnnotations.Schema;
using tsp.Domain.Common;

namespace tsp.Domain.Entities
{
    public class MessageRoom : BaseEntity
    {
        [ForeignKey(nameof(SenderUser))]
        public Guid SenderUserId { get; set; }
        public User SenderUser { get; set; }
        [ForeignKey(nameof(ReceiverUser))]
        public Guid ReceiverUserId { get; set; }
        public User ReceiverUser { get; set; }
        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}
