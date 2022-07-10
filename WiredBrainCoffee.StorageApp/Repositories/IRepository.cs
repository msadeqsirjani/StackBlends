namespace WiredBrainCoffee.StorageApp.Repositories;

public interface IRepository<TEntity> : IReadRepository<TEntity>, IWriteRepository<TEntity> where TEntity : IEntity
{
}