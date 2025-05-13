using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Users.Models.Entities;

namespace Domivue.Api.Modules.Subscriptions.Models.Entities
{
    public class Subscription : Entity
    {
        public string End { get; set; } = string.Empty;
        public string Start { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;
        public User? User { get; set; }
    }
}