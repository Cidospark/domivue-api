namespace Domivue.Core.Domains;
using System;

public class ListingsTag
{
    public Guid ListingIdv { get; set; }
    public Guid TagId { get; set; }

    public Listing? Listing { get; set; }
    public Tag? Tag { get; set; }
}