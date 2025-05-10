namespace Domivue.Core.Domains;
using System;
using System.Collections.Generic;
public class Category : Entity
{
    public Category(Guid id) : base(id)
    {
    }

    public string Name { get; set; } = "";

    public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
}