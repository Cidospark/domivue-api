namespace Domivue.Core.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domivue.Core.Domains.Validators;

public class Listing : Entity
{
    public Listing(Guid id) : base(id)
    {
    }

    [Required]
    public Guid SellerId { get; set; }

    [Required]
    public Guid SubCategoryId { get; set; }


    public bool IsLiked { get; set; }
    public bool IsWishList { get; set; }
    public bool IsSold { get; set; }
    
    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Max: 50, Min: 3 characters allowed")]
    public string Name { get; set; } = "";

    [Required]
    public string Description { get; set; } = "";

    [PriceCurrencyValidator(ErrorMessage = "Invalid entry for price currency")]
    public string PriceCurrency { get; set; } = "";

    [Required]
    public decimal Price { get; set; }

    public List<Attr> Features { get; set; } = new List<Attr>();
    public List<GalleryImage> GalleryImages { get; set; } = new List<GalleryImage>();
    public List<ListingsTag> ListingsTags { get; set; } = new List<ListingsTag>();
    public List<ListingsCategory> ListingsCategories { get; set; } = new List<ListingsCategory>();
    public SubCategory? SubCategory { get; set; }
    public Location? Location { get; set; }
    public User? Seller { get; set; }
}
