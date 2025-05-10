namespace Domivue.Core.Domains;

public class CeilingHeights : Entity
{
    public CeilingHeights(Guid id) : base(id)
    {
    }

    public Guid ExtrasId { get; set; }
    public string Main { get; set; } = "";
    public string Upper { get; set; } = "";
    public string Foyer { get; set; } = "";

    public Extras? Extras { get; set; }
}
