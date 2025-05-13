namespace Domivue.Api.Modules.Listings.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Users.Models.Entities;

public class ListingComment : Entity
{
        [Required]
        public string ListingId { get; set; } = string.Empty;

        [Required]
        public string CommenterId { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Message { get; set; } = string.Empty;
        public double Rated { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<ListingCommentLiker> Likes { get; set; } = new List<ListingCommentLiker>();
        public User? Commmenter { get; set; }
        public Listing? Listing { get; set; }
}
