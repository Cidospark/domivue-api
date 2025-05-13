using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;

namespace Domivue.Api.Domains
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
    }
}