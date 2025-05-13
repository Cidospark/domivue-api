namespace Domivue.Api.Modules.Listings.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Tags.Models.Entities;

public class ListingsTag
{

    [Key]
    public Guid ListingsTagId { get; set; } = Guid.NewGuid();

    [Required]
    public Guid ListingId { get; set; }
    [Required]
    public Guid TagId { get; set; }

    public Listing? Listing { get; set; }
    public Tag? Tag { get; set; }
}