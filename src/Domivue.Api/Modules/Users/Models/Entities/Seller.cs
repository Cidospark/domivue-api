using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Subscriptions.Models.Entities;
using Domivue.Api.Modules.WorkHistories.Models.Entities;

namespace Domivue.Api.Modules.Users.Models.Entities
{
    public class Seller : Entity
    {
        public double Rated { get; set; }
        public int Likes { get; set; }
        public string Role { get; set; } = "";
        public Guid UserId { get; set; }
        public bool IsBlock { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string Bio { get; set; } = "";
        public List<SellerLiker> Likers { get; set; } = new List<SellerLiker>();
        public List<SellerFollower> Follower { get; set; } = new List<SellerFollower>();
        public List<WorkHistory> WorkHistories { get; set; } = new List<WorkHistory>();
        public string Availability { get; set; } = string.Empty;
        
        public Guid SubscriberId { get; set; }
        public Subscription? Subscriber { get; set; }
        public User? User { get; set; }
    }

    public class SellerLiker : Entity
    {
        public Guid SellerId { get; set; }
        public Seller? Seller { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
    }

    public class SellerFollower : Entity
    {
        public Guid SellerId { get; set; }
        public Seller? Seller { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}