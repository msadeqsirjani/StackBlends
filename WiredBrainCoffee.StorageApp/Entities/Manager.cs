namespace WiredBrainCoffee.StorageApp.Entities;

public class Manager : Employee
{
    protected Manager() { }

    public Manager(string name) : base(name)
    {
    }

    public override string ToString() => base.ToString() + " (Manager)";
}