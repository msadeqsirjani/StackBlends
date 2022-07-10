namespace WiredBrainCoffee.StackApp;

public class SimpleStack<T>
{
    private readonly T?[] _values;
    private int _current = -1;

    public SimpleStack() => _values = new T?[10];

    public int Count => _current + 1;

    public void Push(T? value) => _values[++_current] = value;

    public T? Pop() => _values[_current--];
}