using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;

public class Location: Entity{
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public decimal LatitudeDelta { get; set; }
    public decimal LongitudeDelta { get; set; }

    [Required]
    public string City { get; set; } = "";
    [Required]
    public string Country { get; set; } = "";
    [Required]
    public string State { get; set; } = "";
}