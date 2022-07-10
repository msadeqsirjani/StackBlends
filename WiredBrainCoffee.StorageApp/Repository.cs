namespace WiredBrainCoffee.StorageApp;

public class Repository<TEntity> where TEntity : class, IEntity, new()
{
    private readonly List<TEntity> _entities = new();
    private int _id;

    public Repository() => _id = 0;

    public TEntity? FirstOrDefault(int id) => _entities.FirstOrDefault(x => x.Id == id);

    public void Add(TEntity entity) => _entities.Add(entity);

    public void Remove(TEntity entity) => _entities.Remove(entity);

    public void Save() =>
        _entities.Where(x => x.Id == 0)
            .ToList()
            .ForEach(entity =>
            {
                entity.Id = ++_id;

                Console.WriteLine(entity);
            });
}