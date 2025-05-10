using System.ComponentModel.DataAnnotations;

namespace Domivue.Core.Domains
{
    public class Chat : Entity
    {
        [Required]
        public Guid SenderId { get; set; }
        [Required]
        public Guid ReceiverId { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        
        [Required]
        public string Message { get; set; } = "";

        public Chat(Guid id, Guid receiverId, Guid senderId, DateTime timestamp, string message)
            : base(id)
        {
            SenderId = senderId;
            ReceiverId = receiverId;
            Timestamp = timestamp;
            Message = message;
        }

        public Chat(Guid id): base(id)
        {
            
        }
    }
}