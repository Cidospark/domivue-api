namespace Domivue.Api.Modules.Tags.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Listings.Models.Entities;

public class Tag : Entity
{

    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
    public string Name { get; private set; } = "";

    public List<ListingsTag> Tags { get; set; } = new List<ListingsTag>();
}