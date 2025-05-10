namespace Domivue.Core.Domains;
using System;

public class Location : Entity
{
    public Location(Guid id): base(id)
    {
    }

    public Guid ListingId { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public decimal LatitudeDelta { get; set; }
    public decimal LongitudeDelta { get; set; }
    public string City { get; set; } = "";
    public string Country { get; set; } = "";
    public string State { get; set; } = "";

    public Listing? Listing { get; set; }
}