namespace Domivue.Api.Modules.Listings.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Categories.Models.Entities;

public class ListingsCategory
{
    [Key]
    public Guid ListingsCategoryId { get; set; } = Guid.NewGuid();
    [Required]
    public Guid ListingId { get; set; }
    [Required]
    public Guid CategoryId { get; set; }

    public Listing? Listing { get; set; }
    public Category? Category { get; set; }
}