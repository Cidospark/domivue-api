namespace Domivue.Core.Domains;

public class UnheatedLivingSpace : Entity
{
    public UnheatedLivingSpace(Guid id) : base(id)
    {
    }

    public Guid ExtrasId { get; set; }
    public string Type { get; set; } = "";
    public string Size { get; set; } = "";

    public Extras? Extras { get; set; }
}
