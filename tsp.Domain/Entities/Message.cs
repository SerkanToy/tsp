using System.ComponentModel.DataAnnotations.Schema;
using tsp.Domain.Common;

namespace tsp.Domain.Entities
{
    public class Message : BaseEntity
    {
        public string MessageContent { get; set; }
        [ForeignKey(nameof(MessageRoom))]
        public Guid MessageRoomId { get; set; }
        public MessageRoom MessageRoom { get; set; }
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
