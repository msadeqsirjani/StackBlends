using WiredBrainCoffee.StackApp;

SimpleStackDoubles();
SimpleStackStrings();

StackDoubles();
StackStrings();

Console.ReadKey();

void SimpleStackDoubles()
{
    SimpleStack<double> stack = new();

    stack.Push(1.2);
    stack.Push(2.8);
    stack.Push(3.0);

    while (stack.Count > 0)
        Console.WriteLine(stack.Pop());
}

void StackDoubles()
{
    Stack<double> stack = new();

    stack.Push(1.2);
    stack.Push(2.8);
    stack.Push(3.0);

    while (stack.Count > 0)
        Console.WriteLine(stack.Pop());
}

void SimpleStackStrings()
{
    SimpleStack<string> stack = new();

    stack.Push("Wired Brain Coffee");
    stack.Push("Plural Sight");

    while (stack.Count > 0)
        Console.WriteLine(stack.Pop());
}

void StackStrings()
{
    Stack<string> stack = new();

    stack.Push("Wired Brain Coffee");
    stack.Push("Plural Sight");

    while (stack.Count > 0)
        Console.WriteLine(stack.Pop());
}