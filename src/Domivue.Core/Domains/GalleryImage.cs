using System.ComponentModel.DataAnnotations;

namespace Domivue.Core.Domains;
public class GalleryImage : Entity
{
    public GalleryImage(Guid id) : base(id)
    {
    }

    [Required]
    public Guid ListingId { get; set; }

    [Required]
    public string PhotoUrl { get; set; } = "";
    
    public string PublicId { get; set; } = "";
    public bool IsHero { get; set; }

    public Listing? Listing { get; set; }
}