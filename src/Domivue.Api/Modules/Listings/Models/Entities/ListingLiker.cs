namespace Domivue.Api.Modules.Listings.Models.Entities;
using System;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Users.Models.Entities;

public class ListingLiker : Entity
{
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Guid ListingId { get; set; }
        public Listing? Listing { get; set; }
        public DateTime LikedAt { get; set; } = DateTime.UtcNow;
}
