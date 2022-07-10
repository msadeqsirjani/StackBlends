using WiredBrainCoffee.StorageApp.Entities.Common;

namespace WiredBrainCoffee.StorageApp.Repositories;

public interface IWriteRepository<in TEntity> where TEntity : IEntity
{
    void Add(TEntity entity);
    void Remove(TEntity entity);
    void Save();

}