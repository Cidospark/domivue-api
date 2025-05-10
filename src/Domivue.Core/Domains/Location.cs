namespace Domivue.Core.Domains;
using System;
using System.ComponentModel.DataAnnotations;

public class Location : Entity
{
    public Location(Guid id): base(id)
    {
    }

    [Required]
    public Guid ListingId { get; set; }
    
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

    public Listing? Listing { get; set; }
}