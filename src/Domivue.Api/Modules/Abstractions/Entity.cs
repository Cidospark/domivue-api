namespace Domivue.Api.Modules.Abstractions;
public abstract class Entity{
    public string Id { get; init; } = Guid.NewGuid().ToString();
    private readonly List<IDomainEvent> _domainEvents = new();

    public IReadOnlyList<IDomainEvent> GetDomainEvents(){
        return _domainEvents.ToList();
    }

    public void ClearDomainEvents(){
        _domainEvents.Clear();
    }

    protected void RaisDomainEvent(IDomainEvent domainEvent){
        _domainEvents.Add(domainEvent);
    }
}