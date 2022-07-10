namespace WiredBrainCoffee.StorageApp;

public class Employee : Entity
{
    public Employee(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public override string ToString() => $"{nameof(Employee)}\nId: {Id}, Name: {Name}";
}