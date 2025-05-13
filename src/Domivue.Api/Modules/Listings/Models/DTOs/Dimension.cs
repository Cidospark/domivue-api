namespace Domivue.Api.Modules.Listings.Models.DTOs;
using System;

public class Dimension
{

    public Guid ListingId { get; set; }
    public string Width { get; set; } = "";
    public string Height { get; set; } = "";
    public string Depth { get; set; } = "";

}