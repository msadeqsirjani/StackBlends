using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageApp.Data;
using WiredBrainCoffee.StorageApp.Entities.Common;

namespace WiredBrainCoffee.StorageApp.Repositories;

public class SqlRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    private readonly StorageAppDbContext _context;
    private readonly DbSet<TEntity> _db;

    public SqlRepository()
    {
        _context = new StorageAppDbContext();
        _db = _context.Set<TEntity>();
    }

    public IEnumerable<TEntity> Select() => _db.AsNoTracking().ToList();

    public TEntity? FirstOrDefault(int id) => _db.FirstOrDefault(x => x.Id == id);

    public void Add(TEntity entity) => _db.Add(entity);

    public void Remove(TEntity entity) => _db.Remove(entity);

    public void Save() => _context.SaveChanges();
}