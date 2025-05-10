using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Domivue.Core.Domains
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
        public string FirstName { get; set; } = "";

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
        public string LastName { get; set; } = "";
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<WorkHistory> WorkHistories { get; set; } = new List<WorkHistory>();
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public User()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        private readonly List<IDomainEvent> _domainEvents = new();

        public IReadOnlyList<IDomainEvent> GetDomainEvents(){
            return _domainEvents.ToList();
        }

        public void ClearDomainEvents(){
            _domainEvents.Clear();
        }

        protected void RaisDomainEvent(IDomainEvent domainEvent){
            _domainEvents.Add(domainEvent);
        }
    }
}