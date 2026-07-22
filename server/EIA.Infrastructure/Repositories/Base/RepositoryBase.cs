using EIA.Core.Interfaces.Repositories;

namespace EIA.Infrastructure.Repositories.Base;

public abstract class RepositoryBase<TEntity> : IRepository<TEntity>
    where TEntity : class
{
    protected readonly Dictionary<Guid, TEntity> Storage = new();

    protected abstract Guid GetEntityId(TEntity entity);

    public virtual void Add(TEntity entity)
    {
        Storage[GetEntityId(entity)] = entity;
    }

    public virtual IReadOnlyCollection<TEntity> GetAll()
    {
        return Storage.Values.ToList();
    }

    public virtual TEntity? GetById(Guid id)
    {
        Storage.TryGetValue(id, out var entity);

        return entity;
    }

    public virtual void Update(TEntity entity)
    {
        Storage[GetEntityId(entity)] = entity;
    }

    public virtual void Remove(Guid id)
    {
        Storage.Remove(id);
    }
}