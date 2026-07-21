namespace EIA.Core.Interfaces.Repositories;

public interface IRepository<TEntity>
    where TEntity : class
{
    TEntity? GetById(Guid id);

    IReadOnlyCollection<TEntity> GetAll();

    void Add(TEntity entity);

    void Update(TEntity entity);

    void Remove(Guid id);
}