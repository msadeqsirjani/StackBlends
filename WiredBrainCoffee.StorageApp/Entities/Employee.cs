using WiredBrainCoffee.StorageApp.Entities.Common;

namespace WiredBrainCoffee.StorageApp.Entities;

public class Employee : Entity
{
    /// <summary>
    /// Use this ctor for EntityFrameworkCore
    /// </summary>
    private Employee()
    {

    }

    public Employee(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public override string ToString() => $"{nameof(Employee)}\nId: {Id}, Name: {Name}";
}