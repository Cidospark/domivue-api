namespace Domivue.Api.Modules.Listings.Models.DTOs;

public class Roof
{

    public Guid ExtrasId { get; set; }
    public string Type { get; set; } = "";
    public string Material { get; set; } = "";
    public string Year { get; set; } = "";
    public string Warranty { get; set; } = "";
    public string Description { get; set; } = "";

}