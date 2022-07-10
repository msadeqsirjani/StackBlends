namespace WiredBrainCoffee.StorageApp.Entities;

public class Employee : Entity
{
    /// <summary>
    /// Use this ctor for EntityFrameworkCore
    /// </summary>
    protected Employee() { }

    public Employee(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public void SetName(string name) => Name = name;

    public override string ToString() => $"{nameof(Employee)}\nId: {Id}, Name: {Name}";
}