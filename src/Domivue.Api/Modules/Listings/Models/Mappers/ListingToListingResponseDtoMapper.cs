using Domivue.Api.Modules.GalleryImages.Models.DTOs;
using Domivue.Api.Modules.Listings.Models.DTOs;
using Domivue.Api.Modules.Listings.Models.Entities;
using Domivue.Api.Modules.Users.Models.DTOs;

public static class ListingToListingResponseDtoMapper{
    public static ListingResponseDto MapToListingResponseDto(this Listing listing)
    {
        var listingRes = new ListingResponseDto();

        if(listing != null){
            listingRes = new ListingResponseDto
            {
                Id = listing.Id,
                SellerId = listing.SellerId,
                SubCategoryId = listing.SubCategoryId,
                IsLiked = listing.IsLiked,
                IsWishList = listing.IsWishList,
                IsSold = listing.IsSold,
                Name = listing.Name,
                Description = listing.Description,
                PriceCurrency = listing.PriceCurrency,
                Price = listing.Price,
                PostDate = listing.PostDate,
                CloseDate = listing.CloseDate
                
            };
        }

        if(listing.GalleryImages != null)
        {
            listingRes.GalleryImages = listing.GalleryImages.Select(g => new GalleryImageResponseDto
            {
                Id = g.Id,
                ListingId = g.ListingId,
                PhotoUrl = g.PhotoUrl,
                PublicId = g.PublicId,
                IsHero = g.IsHero
            }).ToList();
        }

        if(listing.Seller != null)
        {
            listingRes.Seller = new SellerResponseDto
            {
                Id = listing.Seller.Id,
                Rated = listing.Seller.Rated,
                Likes = listing.Seller.Likes,
                Role = listing.Seller.Role,
                UserId = listing.Seller.UserId,
                IsBlock = listing.Seller.IsBlock,
                CreatedAt = listing.Seller.CreatedAt,
                Bio = listing.Seller.Bio
            };
            if(listing.Seller.User != null)
            {
                listingRes.Seller.User = new UserThumbNailResponseDto
                {
                    Id = listing.Seller.User.Id,
                    FirstName = listing.Seller.User.FirstName ?? "",
                    LastName = listing.Seller.User.LastName ?? "",
                    UserName = listing.Seller.User.UserName ?? "",
                    Email = listing.Seller.User.Email ?? "",
                    PhoneNumber = listing.Seller.User.PhoneNumber ?? "",
                    PhotoUrl = listing.Seller.User.PhotoUrl ?? "",
                };
            }
        }

        if(listing.SubCategory != null)
        {
            listingRes.SubCategory = new SubCategoryResponseDto{
                Id = listing.SubCategory.Id,
                Name = listing.SubCategory.Name
                
            };
            if(listing.SubCategory.Category != null)
            {
                listingRes.SubCategory.Category = new CategoryResponseDto
                {
                    Id = listing.SubCategory.Category.Id,
                    Name = listing.SubCategory.Category.Name
                };
            }
        }
        return listingRes;
    }
}