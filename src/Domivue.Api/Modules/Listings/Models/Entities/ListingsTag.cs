namespace Domivue.Api.Modules.Listings.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Tags.Models.Entities;

public class ListingsTag
{

    [Key]
    public string ListingsTagId { get; set; } = Guid.NewGuid().ToString();

    [Required]
    public string ListingId { get; set; } = "";
    [Required]
    public string TagId { get; set; } = "";

    public Listing? Listing { get; set; }
    public Tag? Tag { get; set; }
}