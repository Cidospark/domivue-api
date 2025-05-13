using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Listings.Models.Entities;

namespace Domivue.Api.Modules.GalleryImages.Models.Entities;
public class GalleryImage : Entity
{

    [Required]
    public string ListingId { get; set; } = "";

    [Required]
    public string PhotoUrl { get; set; } = "";
    
    public string? PublicId { get; set; }
    public bool IsHero { get; set; }

    public Listing? Listing { get; set; }
}