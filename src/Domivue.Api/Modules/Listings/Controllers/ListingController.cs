using Domivue.Api.Modules.Listings.Models.Entities;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class ListingController : ControllerBase
{
    private readonly ILogger<ListingController> _logger;
    private readonly IListingRepository _listingRepository;

    public ListingController(ILogger<ListingController> logger, IListingRepository listingRepository)
    {
        _listingRepository = listingRepository;
        _logger = logger;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var listing = await _listingRepository.GetByIdWithDetailsAsync(id);
        return Ok(listing?.MapToListingResponseDto());
    }
}