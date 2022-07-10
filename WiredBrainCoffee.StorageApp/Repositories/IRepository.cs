using WiredBrainCoffee.StorageApp.Entities.Common;

namespace WiredBrainCoffee.StorageApp.Repositories;

public interface IRepository<TEntity> where TEntity : IEntity
{
    TEntity? FirstOrDefault(int id);
    void Add(TEntity entity);
    void Remove(TEntity entity);
    void Save();
}