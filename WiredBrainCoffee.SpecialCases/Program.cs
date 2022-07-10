using WiredBrainCoffee.SpecialCases;

_ = new Container<string>();
_ = new Container<string>();
var container = new Container<int>();

Console.WriteLine($"Container<string>: {Container<string>.Counter}");
Console.WriteLine($"Container<int>: {Container<int>.Counter}");
Console.WriteLine($"Container<bool>: {Container<bool>.Counter}");
Console.WriteLine($"ContainerBase: {ContainerBase.CounterBase}");

container.Print("hello world");