namespace WiredBrainCoffee.StorageApp.Entities;

public class Manager : Employee
{
    private Manager() { }

    public Manager(string name) : base(name)
    {
    }

    public override string ToString() => base.ToString() + " (Manager)";
}