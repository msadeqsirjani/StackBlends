namespace WiredBrainCoffee.StorageApp.Extensions;

public static class ObjectExtensions
{
    public static T? Clone<T>(this T value) where T : IEntity
    {
        var json = JsonSerializer.Serialize(value);

        return JsonSerializer.Deserialize<T>(json);
    }
}