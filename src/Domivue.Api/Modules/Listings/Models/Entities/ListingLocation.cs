namespace Domivue.Api.Modules.Listings.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using Domivue.Api.Modules.Abstractions;

public class ListingLocation : Location
{
    public string ListingId { get; set; } = "";
    public Listing? Listing { get; set; }
}