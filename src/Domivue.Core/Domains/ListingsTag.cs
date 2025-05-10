namespace Domivue.Core.Domains;
using System;
using System.ComponentModel.DataAnnotations;

public class ListingsTag
{

    [Required]
    public Guid ListingIdv { get; set; }
    [Required]
    public Guid TagId { get; set; }

    public Listing? Listing { get; set; }
    public Tag? Tag { get; set; }
}