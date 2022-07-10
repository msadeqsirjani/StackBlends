using WiredBrainCoffee.SpecialCases;

_ = new Container<string>();
_ = new Container<string>();
var container = new Container<int>();

Console.WriteLine($"Container<string>: {Container<string>.Counter}");
Console.WriteLine($"Container<int>: {Container<int>.Counter}");
Console.WriteLine($"Container<bool>: {Container<bool>.Counter}");
Console.WriteLine($"ContainerBase: {ContainerBase.CounterBase}");

container.Print("hello world");

Console.WriteLine(Add(2, 3));
Console.WriteLine(Add(2.6, 3.4));

T Add<T>(T a, T b) where T : notnull
{
    dynamic x = a;
    dynamic y = b;
    return x + y;
}