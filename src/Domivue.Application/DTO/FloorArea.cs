namespace Domivue.Core.Domains
{
    public class FloorArea : Entity
    {
        public FloorArea(Guid id) : base(id)
        {
        }

        public Guid ListingId { get; set; }
        public string Total { get; set; } = "";
        public string Heated { get; set; } = "";
        public string FirstFloor { get; set; } = "";
        public string SecondFloor { get; set; } = "";

        public Listing? Listing { get; set; }
    }
}