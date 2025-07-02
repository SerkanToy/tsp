using System.ComponentModel.DataAnnotations.Schema;

namespace tsp.Domain.Entities
{
    public class MessageRoom
    {
        public string MessageContent { get; set; }
        [ForeignKey(nameof(SenderUser))]
        public Guid? SenderUserId { get; set; }
        public User SenderUser { get; set; }
        [ForeignKey(nameof(ReceiverUser))]
        public Guid ReceiverUserId { get; set; }
        public User ReceiverUser { get; set; }
    }
}
