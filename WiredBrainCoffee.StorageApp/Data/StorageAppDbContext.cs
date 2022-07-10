using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Data;

public class StorageAppDbContext : DbContext
{
    public virtual DbSet<Employee> Employees { get; set; } = null!;
    public virtual DbSet<Organization> Organizations { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        base.OnConfiguring(options);

        options.UseInMemoryDatabase("InMemoryDatabase");
    }
}