namespace Domivue.Core.Domains;
using System;
using System.ComponentModel.DataAnnotations;

public class ListingsCategory
{
    [Required]
    public Guid ListingIdv { get; set; }
    [Required]
    public Guid CategoryId { get; set; }

    public Listing? Listing { get; set; }
    public Category? Category { get; set; }
}