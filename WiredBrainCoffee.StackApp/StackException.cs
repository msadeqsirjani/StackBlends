namespace WiredBrainCoffee.StackApp;

public class StackException : Exception
{
    private StackException(string message) : base(message)
    {
        
    }

    public static StackException ThrowIfFull(string message) => new(message);
    public static StackException ThrowIfEmpty(string message) => new(message);
}