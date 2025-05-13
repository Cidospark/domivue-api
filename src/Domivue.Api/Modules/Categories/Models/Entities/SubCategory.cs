namespace Domivue.Api.Modules.Categories.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Listings.Models.Entities;

public class SubCategory : Entity{
    
    [Required]
    public string CategoryId { get; set; }  = "";

    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
    public string Name { get; set; } = "";

    public Category? Category { get; set; }

    public List<Listing> Listings { get; set; } = new List<Listing>();
}