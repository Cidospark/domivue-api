namespace Domivue.Api.Modules.Listings.Models.DTOs;

public class CeilingHeights
{

    public Guid ExtrasId { get; set; }
    public string Main { get; set; } = "";
    public string Upper { get; set; } = "";
    public string Foyer { get; set; } = "";

    public Extras? Extras { get; set; }
}
