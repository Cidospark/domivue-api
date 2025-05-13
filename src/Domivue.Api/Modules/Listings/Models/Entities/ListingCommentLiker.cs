namespace Domivue.Api.Modules.Listings.Models.Entities;
using System;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Users.Models.Entities;

public class ListingCommentLiker : Entity
{
        public string ListingCommentId { get; set; } = "";
        public string UserId { get; set; } = "";
        public User? User { get; set; }

        public ListingComment? ListingComment { get; set; }
}