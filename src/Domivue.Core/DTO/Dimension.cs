namespace Domivue.Core.Domains;
using System;

public class Dimension : Entity
{
    public Dimension(Guid id) : base(id)
    {
    }

    public Guid ListingId { get; set; }
    public string Width { get; set; } = "";
    public string Height { get; set; } = "";
    public string Depth { get; set; } = "";

    public Listing? Listing { get; set; }
}