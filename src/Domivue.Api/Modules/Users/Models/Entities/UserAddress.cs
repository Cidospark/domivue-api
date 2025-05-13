using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;

namespace Domivue.Api.Modules.Users.Models.Entities
{
    public class UserAddress
    {
        [Key]
        public string UserId { get; set; } = "";


        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string Country { get; set; } = "";

        // Navigation property for the related User entity
        public User? User { get; set; }
    }
}