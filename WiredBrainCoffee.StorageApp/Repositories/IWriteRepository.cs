namespace WiredBrainCoffee.StorageApp.Repositories;

public interface IWriteRepository<in TEntity>
{
    void Add(TEntity entity);
    void Remove(TEntity entity);
    void Save();

}