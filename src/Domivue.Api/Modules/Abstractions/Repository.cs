using Domivue.Api.Configs.Data;
using Domivue.Api.Modules.Abstractions;
using Microsoft.EntityFrameworkCore;

internal abstract class Repository<T> where T: Entity{
    protected readonly ApplicationDbContext _dbContext;
    public Repository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<T?> GetByIdAsync(string id, CancellationToken cancellationToken = default){
        return await _dbContext.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task Add(T entity){
        await _dbContext.Set<T>().AddAsync(entity);
    }
}