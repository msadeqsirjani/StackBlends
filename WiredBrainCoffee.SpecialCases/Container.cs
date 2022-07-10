namespace WiredBrainCoffee.SpecialCases;

public class Container<T> : ContainerBase
{
    public Container() => Counter++;

    public static int Counter { get; private set; }

    public void Print<TValue>(TValue value) => Console.WriteLine(value);
}