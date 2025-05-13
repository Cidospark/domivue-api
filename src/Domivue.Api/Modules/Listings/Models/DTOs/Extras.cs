namespace Domivue.Api.Modules.Listings.Models.DTOs;

using System;
using System.Collections.Generic;

public class Extras
{


    public Guid ListingId { get; set; }
    public List<UnheatedLivingSpace> UnheatedLivingSpaces { get; set; } = new List<UnheatedLivingSpace>();
    public CeilingHeights? CeilingHeights { get; set; }
    public Roof? Roof { get; set; }
    public string Framing { get; set; } = "";
    public string DwellingNumber { get; set; } = "";
    public string BonusAccess { get; set; } = "";
}
