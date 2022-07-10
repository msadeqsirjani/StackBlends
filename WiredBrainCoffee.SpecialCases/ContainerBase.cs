namespace WiredBrainCoffee.SpecialCases;

public class ContainerBase
{
    public ContainerBase() => CounterBase++;

    public static int CounterBase { get; private set; }
}