using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Listings.Models.Entities;
using Domivue.Api.Modules.Users.Models.Entities;

namespace Domivue.Api.Modules.WorkHistories.Models.Entities
{
    public class WorkHistory : Entity
    {
    
        [Required]
        public Guid SellerId { get; private set; }
        public Guid ListingId { get; private set; }
        
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
        public string PropertyName { get; private set; } = "";

        [Required]
        public WorkHistoryLocation? Location { get; set; }

        public string KeyFeatures { get; private set; } = "";
        public DateTime? PostDate { get; private set; }
        public DateTime? CloseDate { get; private set; }
        public string Description { get; private set; } = "";
        public string HeroImage { get; private set; } = "";

        public Listing? Listing { get; private set; }
        public Seller? Seller { get; private set; }
    }

    public class WorkHistoryLocation:Location
    {
        public Guid WorkHistoryId { get; set; }
        public WorkHistory? WorkHistory { get; set; }
    }
}