namespace Domivue.Api.Modules.Users.Models.DTOs;

public class SellerResponseDto
{
    public string Id { get; set; } = "";
    public double Rated { get; set; }
    public int Likes { get; set; }
    public string Role { get; set; } = "";
    public string UserId { get; set; } = "";
    public bool IsBlock { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Bio { get; set; } = "";

    public UserThumbNailResponseDto? User { get; set; }

}
