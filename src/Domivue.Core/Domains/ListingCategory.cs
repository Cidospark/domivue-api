namespace Domivue.Core.Domains;
using System;

public class ListingsCategory
{
    public Guid ListingIdv { get; set; }
    public Guid CategoryId { get; set; }

    public Listing? Listing { get; set; }
    public Category? Category { get; set; }
}