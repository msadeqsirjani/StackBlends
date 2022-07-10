using WiredBrainCoffee.StorageApp.Entities.Common;

namespace WiredBrainCoffee.StorageApp.Entities;

public class Organization : Entity
{
    /// <summary>
    /// Use this ctor for EntityFrameworkCore
    /// </summary>
    private Organization()
    {

    }

    public Organization(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public override string ToString() => $"{nameof(Organization)}\nId: {Id}, Name: {Name}";
}