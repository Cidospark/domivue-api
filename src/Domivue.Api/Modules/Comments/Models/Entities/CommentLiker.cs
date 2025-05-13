namespace Domivue.Api.Modules.Comments.Models.Entities;
using System;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Users.Models.Entities;

public class CommentLiker : Entity
{
        public Guid ListingCommentId { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Comment? ListingComment { get; set; }
}