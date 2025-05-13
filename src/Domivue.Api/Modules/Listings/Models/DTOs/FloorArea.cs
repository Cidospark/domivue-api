namespace Domivue.Api.Modules.Listings.Models.DTOs
{
    public class FloorArea
    {

        public Guid ListingId { get; set; }
        public string Total { get; set; } = "";
        public string Heated { get; set; } = "";
        public string FirstFloor { get; set; } = "";
        public string SecondFloor { get; set; } = "";

    }
}