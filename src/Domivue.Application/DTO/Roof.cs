namespace Domivue.Core.Domains;

public class Roof : Entity
{
    public Roof(Guid id) : base(id)
    {
    }

    public Guid ExtrasId { get; set; }
    public string Type { get; set; } = "";
    public string Material { get; set; } = "";
    public string Year { get; set; } = "";
    public string Warranty { get; set; } = "";
    public string Description { get; set; } = "";

    public Extras? Extras { get; set; }
}