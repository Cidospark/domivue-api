namespace Domivue.Core.Domains;
using System;
using System.Collections.Generic;

public class SubCategory : Entity{
    public SubCategory(Guid id) : base(id)
    {
    }
    
    public Guid CategoryId { get; set; }
    public string Name { get; set; } = "";

    public Category? Category { get; set; }

    public List<Listing> Listings { get; set; } = new List<Listing>();
}