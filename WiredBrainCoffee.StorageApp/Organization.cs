namespace WiredBrainCoffee.StorageApp;

public class Organization : Entity
{
    public Organization(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public override string ToString() => $"{nameof(Organization)}\nId: {Id}, Name: {Name}";
}