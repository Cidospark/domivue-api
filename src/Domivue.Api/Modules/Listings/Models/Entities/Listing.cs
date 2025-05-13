namespace Domivue.Api.Modules.Listings.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Categories.Models.Entities;
using Domivue.Api.Modules.GalleryImages.Models.Entities;
using Domivue.Api.Modules.Listings.Validators;
using Domivue.Api.Modules.Users.Models.Entities;

public class Listing : Entity
{
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
    
    public DateTime PostDate { get; set; } = DateTime.UtcNow;
    public DateTime? CloseDate { get; set; } = null;

    public List<Attr> Features { get; set; } = new List<Attr>();
    public List<GalleryImage> GalleryImages { get; set; } = new List<GalleryImage>();
    public List<ListingsTag> ListingsTags { get; set; } = new List<ListingsTag>();
    public List<ListingLiker> ListingsLikers { get; set; } = new List<ListingLiker>();
    public List<ListingsCategory> ListingsCategories { get; set; } = new List<ListingsCategory>();
    public SubCategory? SubCategory { get; set; }
    public ListingLocation? Location { get; set; }
    public Seller? Seller { get; set; }
}
