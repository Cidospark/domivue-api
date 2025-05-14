namespace Domivue.Api.Modules.Listings.Models.DTOs;
using System;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.GalleryImages.Models.DTOs;
using Domivue.Api.Modules.Users.Models.DTOs;

public class ListingResponseDto
{
    public string Id { get; set; } = "";
    public string SellerId { get; set; } = "";
    public string SubCategoryId { get; set; } = "";
    public bool IsLiked { get; set; }
    public bool IsWishList { get; set; }
    public bool IsSold { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string PriceCurrency { get; set; } = "";
    public decimal Price { get; set; }
    public DateTime PostDate { get; set; } = DateTime.UtcNow;
    public DateTime? CloseDate { get; set; } = null;
    public List<GalleryImageResponseDto> GalleryImages { get; set; } = new List<GalleryImageResponseDto>();
    public SellerResponseDto? Seller { get; set; }
    public SubCategoryResponseDto? SubCategory { get; set; }
}
