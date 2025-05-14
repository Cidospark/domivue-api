using Domivue.Api.Configs.Data;
using Domivue.Api.Modules.Listings.Models.Entities;
using Microsoft.EntityFrameworkCore;

internal sealed class ListingRepository : Repository<Listing>, IListingRepository
{
    public ListingRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public Task<Listing?> GetByIdWithDetailsAsync(string id, CancellationToken cancellationToken = default)
    {
        return _dbContext.Set<Listing>()
            .Include(x => x.GalleryImages)
            .Include(x => x.Seller).ThenInclude(x => x.User)
            .Include(x => x.SubCategory).ThenInclude(x => x.Category)
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}