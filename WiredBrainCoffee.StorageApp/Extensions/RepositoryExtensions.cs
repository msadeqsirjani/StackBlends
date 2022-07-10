namespace WiredBrainCoffee.StorageApp.Extensions;

public static class RepositoryExtensions
{
    public static void SaveEntities<TEntity>(this IWriteRepository<TEntity> repository, params TEntity[] entities)
    {
        foreach (var entity in entities) 
            repository.Add(entity);

        repository.Save();
    }
}