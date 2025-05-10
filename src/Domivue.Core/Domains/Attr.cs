using System.ComponentModel.DataAnnotations;

namespace Domivue.Core.Domains
{
    public class Attr : Entity
    {
        public Attr(Guid id) : base(id)
        {
        }

        [Required]
        public Guid ListingId { get; set; }

        // Must be one of the values in Enums/ListingAttrName.cs
        
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
        public string Name { get; set; } = ""; 

        [Required]
        public string Key { get; set; } = "";

        [Required]
        public string Value { get; set; } = "";

        public Listing? Listing { get; set; }
    }
}