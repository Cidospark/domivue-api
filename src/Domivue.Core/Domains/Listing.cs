namespace Domivue.Core.Domains;
using System;
using System.Collections.Generic;
using Domivue.Core.Domains.customAttributesValidators;

public class Listing : Entity
{
    public Listing(Guid id) : base(id)
    {
    }
    public Guid SellerId { get; set; }
    public Guid SubCategoryId { get; set; }
    public bool IsLiked { get; set; }
    public bool IsWishList { get; set; }
    public bool IsSold { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";

    [PriceCurrencyValidator(ErrorMessage = "Invalid entry for price currency")]
    public string PriceCurrency { get; set; } = "";
    public decimal Price { get; set; }

    public List<Attr> ListingAttrs { get; set; } = new List<Attr>();
    public List<GalleryImage> GalleryImages { get; set; } = new List<GalleryImage>();
    public List<ListingsTag> ListingsTags { get; set; } = new List<ListingsTag>();
    public List<ListingsCategory> ListingsCategories { get; set; } = new List<ListingsCategory>();
    public SubCategory? SubCategory { get; set; }
    public Location? Location { get; set; }

    // seller
}
