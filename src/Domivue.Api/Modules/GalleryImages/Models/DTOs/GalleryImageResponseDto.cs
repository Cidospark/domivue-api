namespace Domivue.Api.Modules.GalleryImages.Models.DTOs;

public class GalleryImageResponseDto{
    public string Id { get; set; } = "";
    public string ListingId { get; set; } = "";

    public string PhotoUrl { get; set; } = "";
    
    public string? PublicId { get; set; }
    public bool IsHero { get; set; }
}