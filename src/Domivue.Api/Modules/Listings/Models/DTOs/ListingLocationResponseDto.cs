public class ListingLocationResponseDto{
    public string Id { get; set; } = "";
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public decimal LatitudeDelta { get; set; }
    public decimal LongitudeDelta { get; set; }
    public string City { get; set; } = "";
    public string Country { get; set; } = "";
    public string State { get; set; } = "";
}