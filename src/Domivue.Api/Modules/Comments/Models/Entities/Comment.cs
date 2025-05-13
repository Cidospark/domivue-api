namespace Domivue.Api.Modules.Comments.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Listings.Models.Entities;
using Domivue.Api.Modules.Users.Models.Entities;

public class Comment : Entity
{
        [Required]
        public Guid ListingId { get; set; }

        [Required]
        public Guid CommenterId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Message { get; set; } = string.Empty;
        public double Rated { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<CommentLiker> Likes { get; set; } = new List<CommentLiker>();
        public User? Commmenter { get; set; }
        public Listing? Listing { get; set; }
}
