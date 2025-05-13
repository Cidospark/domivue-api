using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;
using Microsoft.AspNetCore.Identity;

namespace Domivue.Api.Modules.Users.Models.Entities
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
        public string FirstName { get; set; } = "";

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
        public string LastName { get; set; } = "";
        
        [Required]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Max: 1, Min: 1 characters allowed")]
        public char Gender { get; set; }
        public string PhotoUrl { get; set; } = "";
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public UserAddress? Address { get; set; }


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