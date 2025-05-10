using System.ComponentModel.DataAnnotations;

namespace Domivue.Core.Domains
{
    public class WorkHistory : Entity
    {
    
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid ListingId { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
        public string CompanyName { get; set; } = "";

        public string Position { get; set; } = "";
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; } = "";

        public Listing? Listing { get; set; }
        public User? User { get; set; }

        public WorkHistory(Guid id): base(id)
        {
        }

        public WorkHistory(Guid id, 
                           Guid userId, 
                           Guid listingId,
                           string companyName, 
                           string position, 
                           DateTime startDate, 
                           DateTime? endDate, 
                           string description
        )
        : base(id)
        {
            Id = id;
            UserId = userId;
            ListingId = listingId;
            CompanyName = companyName;
            Position = position;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
        }
    }
}