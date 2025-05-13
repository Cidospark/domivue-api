namespace Domivue.Api.Modules.Listings.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Categories.Models.Entities;

public class ListingsCategory
{
    [Key]
    public string ListingsCategoryId { get; set; } = Guid.NewGuid().ToString();
    [Required]
    public string ListingId { get; set; } = "";
    [Required]
    public string CategoryId { get; set; } = "";

    public Listing? Listing { get; set; }
    public Category? Category { get; set; }
}