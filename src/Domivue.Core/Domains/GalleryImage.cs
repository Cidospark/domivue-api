namespace Domivue.Core.Domains;
public class GalleryImage : Entity
{
    public GalleryImage(Guid id) : base(id)
    {
    }

    public Guid ListingId { get; set; }
    public string PhotoUrl { get; set; } = "";
    public string PublicId { get; set; } = "";
    public bool IsHero { get; set; }

    public Listing? Listing { get; set; }
}