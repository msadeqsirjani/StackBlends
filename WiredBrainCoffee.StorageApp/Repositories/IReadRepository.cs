namespace WiredBrainCoffee.StorageApp.Repositories;

public interface IReadRepository<out TEntity>
{
    IEnumerable<TEntity> Select();
    TEntity? FirstOrDefault(int id);
}