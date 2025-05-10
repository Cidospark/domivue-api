namespace Domivue.Core.Domains;
using System;
using System.Collections.Generic;

public class Tag : Entity
{
    public Tag(Guid id) : base(id)
    {
    }

    public string Name { get; set; } = "";

    public List<ListingsTag> Tags { get; set; } = new List<ListingsTag>();
}