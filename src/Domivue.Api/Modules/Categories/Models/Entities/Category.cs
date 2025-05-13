namespace Domivue.Api.Modules.Categories.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;

public class Category : Entity
{
    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
    public string Name { get; set; } = "";

    public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
}