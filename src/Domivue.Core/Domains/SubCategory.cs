namespace Domivue.Core.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class SubCategory : Entity{
    public SubCategory(Guid id) : base(id)
    {
    }
    
    [Required]
    public Guid CategoryId { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
    public string Name { get; set; } = "";

    public Category? Category { get; set; }

    public List<Listing> Listings { get; set; } = new List<Listing>();
}