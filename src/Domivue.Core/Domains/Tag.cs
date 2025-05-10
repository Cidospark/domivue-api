namespace Domivue.Core.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Tag : Entity
{
    public Tag(Guid id) : base(id)
    {
    }

    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
    public string Name { get; set; } = "";

    public List<ListingsTag> Tags { get; set; } = new List<ListingsTag>();
}