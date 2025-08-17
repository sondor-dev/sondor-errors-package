namespace Sondor.Errors.Extensions;

/// <summary>
/// Collection of object extensions.
/// </summary>
public static class ObjectExtensions
{
    /// <summary>
    /// Determines if the instance is empty.
    /// </summary>
    /// <typeparam name="TType">The instance type.</typeparam>
    /// <param name="instance">The instance.</param>
    /// <returns>Returns true if all properties are empty.</returns>
    public static bool IsEmpty<TType>(this TType instance)
        where TType : class
    {
        var totalEmpty = 0;
        var properties = typeof(TType).GetProperties();
        foreach (var property in properties)
        {
            var value = property.GetValue(instance);

            if (property.PropertyType == typeof(DateTimeOffset))
            {
                totalEmpty++;

                continue;
            }

            switch (value)
            {
                case false:
                case 0:
                case null:
                case string str when string.IsNullOrWhiteSpace(str):
                case Array { Length: 0 }:
                    totalEmpty++;

                    continue;
                default:
                    return false;
            }
        }

        return totalEmpty == properties.Length;
    }
}
