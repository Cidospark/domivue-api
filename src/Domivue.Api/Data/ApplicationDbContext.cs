using Domivue.Api.Domains;
using Domivue.Api.Modules.Abstractions;
using Domivue.Api.Modules.Categories.Models.Entities;
using Domivue.Api.Modules.GalleryImages.Models.Entities;
using Domivue.Api.Modules.Listings.Models.Entities;
using Domivue.Api.Modules.Subscriptions.Models.Entities;
using Domivue.Api.Modules.Tags.Models.Entities;
using Domivue.Api.Modules.Users.Models.Entities;
using Domivue.Api.Modules.WorkHistories.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domivue.Api.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Attr> Attrs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<ListingCommentLiker> ListingCommentLikers { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<ListingsCategory> ListingsCategories { get; set; }
        public DbSet<ListingComment> ListingComments { get; set; }
        public DbSet<ListingLiker> ListingLikers { get; set; }
        public DbSet<ListingsTag> ListingsTags { get; set; }
        public DbSet<ListingLocation> ListingLocations { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<SellerLiker> SellerLikers { get; set; }
        public DbSet<SellerFollower> SellerFollowers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<WorkHistory> WorkHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the composite key for ListingsCategory
            modelBuilder.Entity<User>()
            .HasOne(u => u.Address)
            .WithOne(ua => ua.User)
            .HasForeignKey<UserAddress>(ua => ua.UserId);
        }
    }
}