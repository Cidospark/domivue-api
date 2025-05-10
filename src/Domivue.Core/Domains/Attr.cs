namespace Domivue.Core.Domains
{
    public class Attr : Entity
    {
        public Attr(Guid id) : base(id)
        {
        }

        public Guid ListingId { get; set; }

        // Must be one of the values in Enums/ListingAttrName.cs
        public string Name { get; set; } = ""; 
        
        public string Key { get; set; } = "";
        public string Value { get; set; } = "";

        public Listing? Listing { get; set; }
    }
}