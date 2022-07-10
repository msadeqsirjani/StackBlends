namespace WiredBrainCoffee.StorageApp.Entities;

public class Organization : Entity
{
    /// <summary>
    /// Use this ctor for EntityFrameworkCore
    /// </summary>
    protected Organization()
    {

    }

    public Organization(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public override string ToString() => $"{nameof(Organization)}\nId: {Id}, Name: {Name}";
}