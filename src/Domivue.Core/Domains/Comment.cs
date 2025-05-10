using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domivue.Core.Domains
{
    public class Comment : Entity
    {
        [Required]
        public Guid CommenterId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Message { get; set; } = string.Empty;
        public double Rated { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<string> Likes { get; set; }
        public User? Commmenter { get; set; }

        public Comment(Guid id): base(id)
        {
            Likes = new List<string>();
        }
    }
}