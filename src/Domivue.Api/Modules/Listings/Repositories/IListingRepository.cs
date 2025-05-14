using Domivue.Api.Modules.Listings.Models.Entities;

public interface IListingRepository{
    Task<Listing?> GetByIdAsync(string id, CancellationToken cancellationToken = default);
    Task<Listing?> GetByIdWithDetailsAsync(string id, CancellationToken cancellationToken = default);
    // Task<Listing> GetByIdWithDetailsAsync(Guid id, CancellationToken cancellationToken);
    // Task<Listing> GetByIdWithDetailsAndImagesAsync(Guid id, CancellationToken cancellationToken);
    // Task<Listing> GetByIdWithDetailsAndImagesAndCommentsAsync(Guid id, CancellationToken cancellationToken);
    // Task<Listing> GetByIdWithDetailsAndImagesAndCommentsAndLikesAsync(Guid id, CancellationToken cancellationToken);
    // Task<Listing> GetByIdWithDetailsAndImagesAndCommentsAndLikesAndViewsAsync(Guid id, CancellationToken cancellationToken);
    // Task<Listing> GetByIdWithDetailsAndImagesAndCommentsAndLikesAndViewsAndTagsAsync(Guid id, CancellationToken cancellationToken);
    // Task<Listing> GetByIdWithDetailsAndImagesAndCommentsAndLikesAndViewsAndTagsAndUserAsync(Guid id, CancellationToken cancellationToken);
    // Task<Listing> GetByIdWithDetailsAndImagesAndCommentsAndLikesAndViewsAndTagsAndUserAndCategoryAsync(Guid id, CancellationToken cancellationToken);
    // Task<Listing> GetByIdWithDetailsAndImagesAndCommentsAndLikesAndViewsAndTagsAndUserAndCategoryAndLocationAsync(Guid id, CancellationToken cancellationToken);
    // Task<Listing> GetByIdWithDetailsAndImagesAndCommentsAndLikesAndViewsAndTagsAndUserAndCategoryAndLocationAndStatusAsync(Guid id, CancellationToken cancellationToken);       
}